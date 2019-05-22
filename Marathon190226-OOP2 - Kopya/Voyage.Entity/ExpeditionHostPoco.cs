using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.Entity
{
    public class ExpeditionHostPoco
    {
        public BusExpeditionPoco BusExpedition { get; set; }
        public HostPoco Host { get; set; }

    }
}
