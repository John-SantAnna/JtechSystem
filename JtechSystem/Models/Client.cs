using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtechSystem.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public Company Company { get; set; }
        public List<Ticket> ClientTickets = new List<Ticket>();
    }
}
