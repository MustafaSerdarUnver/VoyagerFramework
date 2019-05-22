using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.Entity
{
    public class ExpeditionDriverPoco
    {
        public BusExpeditionPoco BusExpedition { get; set; }
        public DriverPoco Driver { get; set; }
    }
}
