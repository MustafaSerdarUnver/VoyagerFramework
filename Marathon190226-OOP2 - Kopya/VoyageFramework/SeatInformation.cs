using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public struct SeatInformation
    {
        public int Number { get;}
        public SeatSection Section { get;}
        public SeatCategory Category { get;}

        public SeatInformation(int number,SeatSection section,SeatCategory category)
        {
            Number = number;
            Section = section;
            Category = category;
        }
    }
}
