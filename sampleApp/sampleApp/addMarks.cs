using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace sampleApp
{
    public partial class addMarks : Form
    {
        String connection = "Server=localhost;Database=test;Uid=root;Pwd=shir";
        MySqlConnection con;
        MySqlCommand cmd;

        public addMarks()
        {
            con = new MySqlConnection(connection);
            InitializeComponent();
            display();
        }

        void display()
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("select name,semester,percentage from test", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into test(name,semester,percentage) values(?name,?semester,?percentage)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("name", name.Text);
            cmd.Parameters.AddWithValue("semester", semester.Text);
            cmd.Parameters.AddWithValue("percentage", percentage.Text);
            cmd.ExecuteNonQuery();
            display();
            clear();
        }
        void clear()
        {
            name.Text = "";
            semester.Text = "";
            percentage.Text = "";

        }
    }
}
