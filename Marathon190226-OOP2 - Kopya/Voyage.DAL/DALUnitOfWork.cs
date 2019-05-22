using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.DAL.Repository;
using Voyage.Entity;

namespace Voyage.DAL
{
    public class DALUnitOfWork:IDisposable
    {
        private VoyageContext vygCtx;

        public IRepo<BusExpeditionPoco> BusExpeditionPocos { get; set; }
        public IRepo<BusPoco> BusPocos { get; set; }
        public IRepo<BusTypePoco> BusTypePocos { get; set; }
        public IRepo<DriverPoco> DriverPocos { get; set; }
        public IRepo<HostPoco> HostPocos { get; set; }
        public IRepo<PersonPoco> PersonPocos { get; set; }
        public IRepo<RoutePoco> RoutePocos { get; set; }
        public IRepo<SeatInformationPoco> SeatInformationPocos { get; set; }
        public IRepo<TicketPoco> TicketPocos { get; set; }

        public DALUnitOfWork()
        {
            vygCtx = new VoyageContext();

            BusExpeditionPocos = new BusExpeditionRepo(vygCtx);
            BusPocos = new BusRepo(vygCtx);
            BusTypePocos = new BusTypeRepo(vygCtx);
            DriverPocos = new DriverRepo(vygCtx);
            HostPocos = new HostRepo(vygCtx);
            PersonPocos = new PersonRepo(vygCtx);
            RoutePocos = new RouteRepo(vygCtx);
            SeatInformationPocos = new SeatInformationRepo(vygCtx);
            TicketPocos = new TicketRepo(vygCtx);
        }

        public void SaveChanges()
        {
            vygCtx.SaveChanges();
        }

        public void Dispose()
        {
            vygCtx.Dispose();
        }
    }
}
