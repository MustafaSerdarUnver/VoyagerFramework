using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.Entity
{
    public class BusPoco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusId { get; set; }
        [MaxLength(64)]
        [Required]
        public string Make { get; set; }
        [MaxLength(20)]
        [Required]
        public string Plate { get; set; }
        public BusTypePoco BusType { get; set; }
    }
}
