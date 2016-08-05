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
    public partial class report : System.Web.UI.Page
    {
        String connection = "Server=localhost;Database=test;Uid=root;Pwd=shir";
        MySqlConnection con;
        MySqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(connection);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            display();
        }
        void display()
        {
            con.Open();
          //MySqlDataAdapter ad = new MySqlDataAdapter("select * from student where semester = '"+semDropDown.Text"'", con);
            MySqlDataAdapter ad = new MySqlDataAdapter("select name,percentage,semester from test where semester ='" + semDropDown.Text + "'", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();

        }
    }
}