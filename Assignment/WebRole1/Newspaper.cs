using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Services;  // + ref System.data.Services
using System.Data.Services.Client;

namespace WebRole1
{
    public class Newspapaper
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Double Price{ get; set; }

        public String CountryOfDelivery { get; set; }
    }

    public class NewspapaerDataModel : DataServiceContext
    {
        private List<Newspapaper> _emps;

        public NewspapaerDataModel(Uri url):base(url)
        {
            _emps = new List<Newspapaper> {
                        new Newspapaper(){ID = 0, Name="The Irish Times", Price=2.5, CountryOfDelivery="Ireland"},
                        new Newspapaper(){ID = 1, Name="Wall Street Journal", Price=2.0, CountryOfDelivery="USA"},
                        new Newspapaper(){ID = 2, Name="The Sun", Price=1.5, CountryOfDelivery="Ireland"},
                        new Newspapaper(){ID = 3, Name="The Daily Telegraph", Price=1.0, CountryOfDelivery="United Kingdom"},
                        new Newspapaper(){ID = 4, Name="Daily Mirror", Price=1.0, CountryOfDelivery="Unitied Kingdom"},
                        new Newspapaper(){ID = 5, Name="Chicago Sun-Times", Price=2.0, CountryOfDelivery="USA"},
                        new Newspapaper(){ID = 6, Name="The Denver Post", Price=3.0, CountryOfDelivery="USA"}
            };
        }



        public List<Newspapaper> getListPersons()
        {
            return _emps; 
        }
        public IQueryable<Newspapaper> Persons
        {
            get { return _emps.AsQueryable<Newspapaper>(); }
        }
    }


    public class PersonService : DataService<NewspapaerDataModel>
    {
        public static void InitializeService(IDataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.SetServiceOperationAccessRule("*",
            ServiceOperationRights.All);
        }
    }



}