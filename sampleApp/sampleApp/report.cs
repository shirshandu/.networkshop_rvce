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
    public partial class report : Form
    {
        String connection = "Server=localhost;Database=test;Uid=root;Pwd=shir";
        MySqlConnection con;
        MySqlCommand cmd;
        public report()
        {
            con = new MySqlConnection(connection);
            InitializeComponent();
        }
        void display()
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("select name,semester,percentage from test", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void search_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter ad = new MySqlDataAdapter("select name,percentage,semester from test where semester ='" + comboBox1.Text + "'", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
