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
        public List<Newspaper> listNewsPaper;

        public void display(int ind)
        {


            var q = from c in ctx.Newspaper

                    select c;



            index = ind;
            int count = 0;
            foreach (var p in q)
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

        public void delete(int index)
        {
            var query = from c in ctx.Newspaper
                        where c.ID.Equals(index)
                        select c;
            var p = query.ElementAt(0);
            ctx.getListNewspaper().Remove(p);
            ctx.SaveChanges();
            count--;
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
            if (firstTime)
                setUpTable();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(TextBox5.Text);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;
            display(index);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int searchID = Convert.ToInt32(TextBox1.Text);

            var q = from c in ctx.Newspaper
                    where c.ID == searchID
                    select c;

            var p = q.ElementAt(0);
            TextBox1.Text = "" + p.ID;
            TextBox2.Text = "" + p.Name;
            TextBox3.Text = "" + p.Price;
            TextBox4.Text = "" + p.CountryOfDelivery;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (index < count - 1) index++;
            display(index);
        }
    }
}