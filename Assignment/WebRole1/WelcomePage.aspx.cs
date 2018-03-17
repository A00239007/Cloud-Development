using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Services;  // + ref System.data.Services
using System.Data.Services.Client;

namespace WebRole1
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        public static int index = 0, count = 0;
        public static bool firstTime = true;
        public static NewspaperDataModel ctx;

        public void display(int ind)
        {
            var query = from c in ctx.Newspaper
                    select c;

            index = ind;
            int count = 0;
            foreach (var p in query)
            {
                if (count == ind)
                {
                    TextBox1.Text = "" + p.ID;
                    TextBox2.Text = "" + p.Name;
                    TextBox3.Text = "" + p.Price;
                    TextBox4.Text = "" + p.CountryOfDelivery;
                }
                count++;
            }
            ctx.SaveChanges();
        }

        public void setUpTable()
        {
            ctx = new NewspaperDataModel(new Uri("http://localhost:12196/PersonService.svc"));
            ctx.MergeOption = MergeOption.AppendOnly;
            var q = from c in ctx.Newspaper
                    select c;

            foreach (var Person in q)
            {
                if (firstTime) { count++; }// display(index); }
            }
            display(index);
            firstTime = false;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if(firstTime)
            {
                setUpTable();
            }
        }

        //Delete Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            int idResult;
            if (int.TryParse(TextBox5.Text, out idResult) == false)
            {
                Label7.Text = "Invalid input for id in the search field";
            }
            else
            {
                Label7.Text = "";
                int id = Convert.ToInt32(TextBox5.Text);

                var query = from c in ctx.Newspaper
                            where c.ID == id
                            select c;

                var p = query.ElementAt(0);
                ctx.getListNewspaper().Remove(p);
                ctx.SaveChanges();
                count--;
            }
        }

        //Previous
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Label7.Text = "";
            }
            else
            {
                Label7.Text = "They are no more newspapers to be displayed";
            }
            display(index);
        }

        //Search by ID
        protected void Button6_Click(object sender, EventArgs e)
        {
            int idResult;
            if (int.TryParse(TextBox5.Text, out idResult) == false)
            {
                Label7.Text = "Invalid input for id in the searh field";
            }
            else
            {
                Label7.Text = "";
                int searchID = Convert.ToInt32(TextBox5.Text);

                var query = from c in ctx.Newspaper
                            where c.ID == searchID
                            select c;

                var p = query.ElementAt(0);
                TextBox1.Text = "" + p.ID;
                TextBox2.Text = "" + p.Name;
                TextBox3.Text = "" + p.Price;
                TextBox4.Text = "" + p.CountryOfDelivery;
            }
        }

        //Insert Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            int idResult;
            double priceResult;
            String name = "";
            Double price = 0;
            String countryOfDelivery = "";
            if (int.TryParse(TextBox1.Text,out idResult)==false)
            {
                Label7.Text = "Invalid input for the id field";
            }
            else
            {
                Label7.Text = "";
                id = Convert.ToInt32(TextBox1.Text);
                name = TextBox2.Text;
                price = 0;
                if (double.TryParse(TextBox3.Text, out priceResult) == false)
                {
                    Label7.Text = "Invalid input for the price field";
                }
                else
                {
                    Label7.Text = "";
                    price = Convert.ToDouble(TextBox3.Text);
                    countryOfDelivery = TextBox4.Text;
                    Newspaper newspaper = new Newspaper() { ID = id, Name = name, Price = price, CountryOfDelivery = countryOfDelivery };
                    ctx.getListNewspaper().Add(newspaper);
                    ctx.SaveChanges();
                    count++;
                    index = id;
                }
            }
        }

        //Update
        protected void Button5_Click(object sender, EventArgs e)
        {
            double priceResult;
            if (double.TryParse(TextBox3.Text, out priceResult) == false)
            {
                Label7.Text = "Invalid input for the price field";
            }
            else
            {
                Label7.Text = "";
                int id = Convert.ToInt32(TextBox1.Text);

                var q = from c in ctx.Newspaper
                        where c.ID == id
                        select c;

                var p = q.ElementAt(0);

                p.Name = TextBox2.Text;
                p.Price = Convert.ToDouble(TextBox3.Text);
                p.CountryOfDelivery = TextBox4.Text;
                ctx.SaveChanges();
                display(index);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StartingPage.aspx");
        }

        //Next Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (index < count - 1)
            {
                index++;
                Label7.Text = "";
            }
            else
            {
                Label7.Text = "They are no more newspapers to be displayed";
            }
            display(index);
        }
    }
}