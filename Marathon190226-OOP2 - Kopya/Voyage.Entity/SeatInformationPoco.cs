using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.Entity
{
    public class SeatInformationPoco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeatInformationId { get; set; }
        public int Number { get; set; }
        public SeatSection Section { get; set; }
        public SeatCategory Category { get; set; }

    }
}
