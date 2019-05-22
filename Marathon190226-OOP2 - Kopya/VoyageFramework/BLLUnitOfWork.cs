using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.DAL;
using Voyage.Entity;

namespace VoyageFramework
{
    public class BLLUnitOfWork
    {
        public List<BusExpedition> BusExpeditions { get; set; }
        public List<Person> People { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Host> Hosts { get; set; }
        public List<Route> Routes { get; set; }
        public List<SeatInformation> SeatInformations { get; set; }
        public List<StandartBus> StandartBuses { get; set; }
        public List<LuxuryBus> LuxuryBuses { get; set; }
        public List<Ticket> Tickets { get; set; }

        public BLLUnitOfWork()
        {
            BusExpeditions = new List<BusExpedition>();
            People = new List<Person>();
            Hosts = new List<Host>();
            Drivers = new List<Driver>();
            Routes = new List<Route>();
            SeatInformations = new List<SeatInformation>();
            StandartBuses = new List<StandartBus>();
            LuxuryBuses = new List<LuxuryBus>();
            Tickets = new List<Ticket>();
        }

        public List<PersonPoco> KisileriGetir()
        {
            Func<Person, PersonPoco> personConverter = x => new PersonPoco()
            {
                PersonId = x.PersonId,


            };
            using (DALUnitOfWork uow = new DALUnitOfWork())
            {                   
                  uow.PersonPocos.GetAll();
            }

        }
    }
}
