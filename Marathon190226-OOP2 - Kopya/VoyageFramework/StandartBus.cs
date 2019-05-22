using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class StandartBus : Bus
    {
        public int StandartBusId { get; set; }
        private const int CapForStandartBus = 30;
        public override int Capacity { get { return CapForStandartBus; } }

        public override bool HasToilet { get { return false; } }

        public override SeatInformation GetSeatInformation(int seatNumber)
        {
            SeatCategory category = new SeatCategory();
            SeatSection section = new SeatSection();

            if (seatNumber%3==1)
            {
                section = SeatSection.LeftSide;
                category = SeatCategory.Singular;
            }
            else
            {
                section = SeatSection.RightSide;
                if (seatNumber % 3 == 2)
                    category = SeatCategory.Corridor;
                else if (seatNumber % 3 == 0)
                    category = SeatCategory.Window;
            }
            SeatInformation seatInformation = new SeatInformation(seatNumber,section,category);
            return seatInformation;
        }
    }
}
