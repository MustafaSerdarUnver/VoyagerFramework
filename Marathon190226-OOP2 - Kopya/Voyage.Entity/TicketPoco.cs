using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage.Entity
{
    public class TicketPoco 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        public BusExpeditionPoco BusExpedition { get; set; }    
        public SeatInformationPoco SeatInformation { get; set; }
        public PersonPoco Passenger { get; set; }
        public decimal PaidAmount { get; set; }
        
    }
}
