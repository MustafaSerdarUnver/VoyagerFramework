using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public BusExpedition Expedition { get;}
        public SeatInformation SeatInformation { get;}
        public Person Passenger { get;}
        public decimal PaidAmount { get;}

        internal Ticket(BusExpedition expedition,SeatInformation seatInformation,Person passenger,decimal paidAmount)
        {
            this.Expedition = expedition;
            this.SeatInformation = seatInformation;
            this.Passenger = passenger;
            this.PaidAmount = paidAmount;
        }
    }
}
