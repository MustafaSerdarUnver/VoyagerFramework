using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.Entity;

namespace Voyage.DAL
{
    public class VoyageContext :DbContext
    {
        public DbSet<PersonPoco> People { get; set; }
        public DbSet<BusPoco> Busses { get; set; }
        public DbSet<BusExpeditionPoco> BusExpeditions { get; set; }
        public DbSet<BusTypePoco> BusTypes { get; set; }
        public DbSet<DriverPoco> Drivers { get; set; }
        public DbSet<HostPoco> Hosts { get; set; }
        public DbSet<RoutePoco> Routes { get; set; }
        public DbSet<SeatInformationPoco> SeatInformations { get; set; }
        public DbSet<TicketPoco> Tickets { get; set; }


        public VoyageContext() : base("VoyageConnection")
        {

        }

    }
}
