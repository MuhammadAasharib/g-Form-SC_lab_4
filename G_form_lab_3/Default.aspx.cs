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
    public partial class _Default : Page
    {
        String sqlConName = "datasource = localhost; port=3306;username=root;password=";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = connectToDb();

            String textBox1 = TextBox1.Text; //get name
            String textBox2 = TextBox2.Text; //get father name
            String textBox3 = TextBox3.Text; //get contact number
            String textBox4 = TextBox4.Text; //get address
            String textBox5 = TextBox5.Text; //get email
            String textBox6 = TextBox6.Text.ToString(); //get date of birth
            String dt = String.Format("{0:yyyy/MM/dd HH:mm:ss}", Convert.ToDateTime(textBox6));
            
            String query1 = "insert into " + "g_forms" + "." + "user_info(" + "name,f_name,con_no,addr,email,dob" + ")" + "values ('" + textBox1 + "','" + textBox2 + "','" + textBox3 + "','" + textBox4 + "','" + textBox5 + "','" + dt + "');";

            MySqlCommand command1 = new MySqlCommand(query1, con);
            try {
                command1.ExecuteReader();
            }
            catch(Exception ex)
            {
                
            }
            closeDbConnection(con);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx");
        }

        //Deleting the student on the basis of student id
        protected void Button3_Click(object sender, EventArgs e)
        {
            String textBox7 = TextBox7.Text;
            String query1 = "delete from g_forms.user_info where id ="+ textBox7;
            MySqlConnection con = connectToDb();
            MySqlCommand com = new MySqlCommand(query1, con);
            com.ExecuteReader();
        }
    }
}