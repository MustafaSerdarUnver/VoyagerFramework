using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.Entity
{
    public class BusExpeditionPoco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusExpeditionId { get; set; }
        public BusPoco Bus { get; set; }
        public RoutePoco Route { get; set; }
        public DateTime DepartureTime { get; set; }
        public bool HasSnackService { get; set; }

    }
}
