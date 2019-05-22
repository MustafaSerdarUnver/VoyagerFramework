using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyage.DAL;
using Voyage.Entity;

namespace VoyageFramework
{
    public abstract class Bus
    {
        public int BusId { get; set; }
        public string Make { get; }
        public string Plate { get; set; }
        public abstract int Capacity { get;}
        public virtual bool HasToilet { get;}
        public abstract SeatInformation GetSeatInformation(int seatNumber);
    }
}
