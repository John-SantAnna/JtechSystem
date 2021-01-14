using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtechSystem.Models
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public List<Ticket> Tickets = new List<Ticket>();
    }
}
