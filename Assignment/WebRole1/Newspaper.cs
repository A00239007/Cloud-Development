using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Services;  // + ref System.data.Services
using System.Data.Services.Client;

namespace WebRole1
{
    public class Newspaper
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public String CountryOfDelivery { get; set; }
    }

    public class NewspaperDataModel : DataServiceContext
    {
        private List<Newspaper> _emps;

        public NewspaperDataModel(Uri url) : base(url)
        {
            _emps = new List<Newspaper> {
                        new Newspaper(){ID = 0, Name="The Irish Times", Price=2.5, CountryOfDelivery="Ireland"},
                        new Newspaper(){ID = 1, Name="Wall Street Journal", Price=2.0, CountryOfDelivery="USA"},
                        new Newspaper(){ID = 2, Name="The Sun", Price=1.5, CountryOfDelivery="Ireland"},
                        new Newspaper(){ID = 3, Name="The Daily Telegraph", Price=1.0, CountryOfDelivery="United Kingdom"},
                        new Newspaper(){ID = 4, Name="Daily Mirror", Price=1.0, CountryOfDelivery="Unitied Kingdom"},
                        new Newspaper(){ID = 5, Name="Chicago Sun-Times", Price=2.0, CountryOfDelivery="USA"},
                        new Newspaper(){ID = 6, Name="The Denver Post", Price=3.0, CountryOfDelivery="USA"}
            };
        }



        public List<Newspaper> getListNewspaper()
        {
            return _emps;
        }
        public IQueryable<Newspaper> Newspaper
        {
            get { return _emps.AsQueryable<Newspaper>(); }
        }
    }


    public class NewsPaperService : DataService<NewspaperDataModel>
    {
        public static void InitializeService(IDataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.SetServiceOperationAccessRule("*",
            ServiceOperationRights.All);
        }
    }



}