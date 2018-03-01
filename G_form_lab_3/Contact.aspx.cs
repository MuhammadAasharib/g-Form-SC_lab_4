using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace G_form_lab_3
{
    public partial class Contact : Page
    {
        String sqlConName = "datasource = localhost; port=3306;username=root;password=";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        //connection to db is established through this function
        private MySqlConnection connectToDb()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(sqlConName);
                con.Open();
                if (con.State == ConnectionState.Open)
                {

                }
                return con;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
        
        //close connection function
        private void closeDbConnection(MySqlConnection con)
        {
            con.Close();
        }

        //Button for Displaying user info to admin
        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = connectToDb();
            String query1 = "Select * from g_forms.user_info";
            MySqlCommand com = new MySqlCommand(query1, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = com;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}