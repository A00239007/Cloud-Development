using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace Assignment002
{
    public partial class ApplicationPage : System.Web.UI.Page
    {
        SqlConnection cn;
        static int count = 0;
        static int max = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Simon Harper\\Documents\\Repo\\cloud-development\\Assignment002\\Assignment002\\App_Data\\Database1.mdf;" +
        "Integrated Security=True;Connect Timeout=30";

            cn = new SqlConnection(str);
            cn.Open();
            mycount();
        }

        protected void mycount()
        {   // count no of els in table
            max = 0;
            var cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Newspaper";
            var reader = cmd.ExecuteReader();
            while (reader.Read()) max++;
            reader.Close();
        }

        protected void displayData()
        {
            var cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Newspaper";
            var reader = cmd.ExecuteReader();
            for (int i = 0; i < count; i++)
            {
                reader.Read();
            }
            TextBox1.Text = "" + reader[0];
            TextBox2.Text = "" + reader[1];
            TextBox3.Text = "" + reader[2];
            TextBox4.Text = "" + reader[3];
            reader.Close();
        }

        protected void displaySearchData(int id)
        {
            var cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Newspaper where id = "+id+"";
            var reader = cmd.ExecuteReader();

            for(int i = 0; i<count; i++)
            {
                reader.Read();
            }
            TextBox1.Text = "" + reader[0];
            TextBox2.Text = "" + reader[1];
            TextBox3.Text = "" + reader[2];
            TextBox4.Text = "" + reader[3];
            reader.Close();
        }

        protected void deleteData(int id)
        {
            var cmd = cn.CreateCommand();
            string query = "delete from newspaper where id = " + id + "";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            count--;
            displayData();
        }

        //Search Button
        protected void Button7_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox5.Text);
            displaySearchData(id);
        }

        //Update Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            float price = (float) Convert.ToDouble(TextBox3.Text);
            string country = TextBox4.Text;
            int result;
            if (int.TryParse(name, out result) == false&&int.TryParse(country,out result)==false)
            {
                Label7.Text = "";
                var cmd = cn.CreateCommand();
                string query = "update Newspaper set name = @Name, country_of_delivery = @Country, price = @Price where id = @Id;";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    Label7.Text = "Update Succesfully";
                }
                catch (Exception ex)
                {
                    Label7.Text = ex.Message;
                }
            }
            else
            {
                Label7.Text = "Invalid input for Name or Country";
            }
        }

        //Next Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (count < max)
            {
                Label7.Text = "";
                count++;
                displayData();
            }
            else
            {
                Label7.Text = "They're no more newspapers to display";
            }
        }

        //Previous Button
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                Label7.Text = "";
                count--;
                displayData();
            }
            else
            {
                Label7.Text = "They're no more newspapers to display";
            }
        }

        //Insert Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = TextBox2.Text;
            float price = (float)Convert.ToDouble(TextBox3.Text);
            string country = TextBox4.Text;
            int result;
            if (int.TryParse(name,out result)==false&&int.TryParse(country,out result)==false)
            {
                var cmd = cn.CreateCommand();
                string query = "insert into newspaper values('" + name + "', " + price + ", '" + country + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            else
            {
                Label7.Text = "Invalid input for name and country fields";
            }
        }

        //Delete Button
        protected void Button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox5.Text);
            deleteData(id);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewspaperPage.aspx");
        }
    }
}