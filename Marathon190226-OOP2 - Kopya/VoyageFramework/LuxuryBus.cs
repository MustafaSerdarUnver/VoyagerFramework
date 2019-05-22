using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class LuxuryBus : Bus
    {
        public int LuxuryBusId { get; set; }
        private const int CapForLuxBus = 20;
        public override int Capacity { get { return CapForLuxBus; } }

        public override bool HasToilet { get { return true; } }

        public override SeatInformation GetSeatInformation(int seatNumber)
        {
            SeatSection section = new SeatSection();
            SeatCategory category = new SeatCategory();

            category = SeatCategory.Singular;
            if (seatNumber % 2 == 1)
                section = SeatSection.LeftSide;
            else if (seatNumber % 2 == 0)
                section = SeatSection.RightSide;
            SeatInformation seatInformation = new SeatInformation(seatNumber,section,category);
            return seatInformation;
        }
    }
}
