using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{

    // Handler dla problemów technicznych
    class TechnicalProblemHandler : Handler
    {
        public override void HandleTicket(Ticket ticket)
        {
            if (ticket.Type == "Technical Problem")
            {
                Console.WriteLine("Obsługa biletu związana z problemem technicznym: " + ticket.Description);
            }
            else if (Successor != null)
            {
                Successor.HandleTicket(ticket);
            }
        }
    }
}
