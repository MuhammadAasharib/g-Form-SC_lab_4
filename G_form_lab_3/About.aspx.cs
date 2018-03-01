using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace G_form_lab_3
{
    public partial class About : Page
    {
        String sqlConName = "datasource = localhost; port=3306;username=root;password=";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String textBox1 = TextBox1.Text;    //get username from textbox
            String textBox2 = TextBox2.Text;    //get password from textbox
            MySqlConnection con = connectToDb();
            String query1 = "Select * from g_forms.admin where name='"+textBox1 + "' and pass='" +textBox2 + "';";
            MySqlCommand com = new MySqlCommand(query1, con);
            MySqlDataReader reader = com.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                // Correct
                Response.Redirect("Contact.aspx");  //redirect to admin panel if successful
                
            }
            else if (count > 1)
            {
                //duplicate accounts
            }
            else
            {
                //incorrect
                Label1.Text = "Incorrect Password";
            }
            closeDbConnection(con);
        }

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

        private void closeDbConnection(MySqlConnection con)
        {
            con.Close();
        }
    }
}