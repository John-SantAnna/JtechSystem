using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtechSystem.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime ClosedDate { get; set; }
        public Agent Agent { get; set; }
        public Client Client { get; set; }

    }
}
