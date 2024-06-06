using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class Ticket
    {
        public string Type { get; set; }
        public string Description { get; set; }

        public Ticket(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
