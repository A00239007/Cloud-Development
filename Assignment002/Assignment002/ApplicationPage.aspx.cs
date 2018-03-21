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
        static int count = 1;
        static int max = 2;
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
        Directory.GetCurrentDirectory() + "\\NewspaperDatabase.mdf;" +
        "Integrated Security=True;Connect Timeout=30;User Instance=False";

            cn = new SqlConnection(str);
            cn.Open();
            mycount();
            displayData();
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
        protected void Button7_Click(object sender, EventArgs e)
        {

        }
        //Update Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox2.Text);
            string name = TextBox1.Text;
            var cmd = cn.CreateCommand();
            string query = "UPDATE [Players] SET [Age]= @Age_ID where [Name]= @Name_ID";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Age_ID", id);
            cmd.Parameters.AddWithValue("@Name_ID", name);

            try
            {
                cmd.ExecuteNonQuery();
                TextBox3.Text = "Update Succesfully";
            }
            catch (Exception ex)
            {
                TextBox3.Text = ex.Message;

            }
        }
        //Next Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (count < max) count++;
            displayData();
        }
        //Previous Button
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (count < max) count--;
            displayData();
        }
    }
}