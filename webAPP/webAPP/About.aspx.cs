using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace webAPP
{
    public partial class About : System.Web.UI.Page
    {
        String connection = "Server=localhost; Database=test; Uid = root; Pwd = shir";
        MySqlConnection con;
        MySqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(connection);
            display();
        }

        protected void save_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into test(name,semester,percentage) values (?name,?semester,?percentage)";
            cmd.Parameters.AddWithValue("name",name.Text);
            cmd.Parameters.AddWithValue("semester", semester.Text);
            cmd.Parameters.AddWithValue("percentage", percentage.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script type=\"text/javascript\">alert('Data Inserted');</script>");
            display();
        }
        void display()
        {
            con.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from test", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }
    }
}
