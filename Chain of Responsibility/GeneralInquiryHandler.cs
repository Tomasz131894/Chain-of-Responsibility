using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class GeneralInquiryHandler : Handler
    {
        public override void HandleTicket(Ticket ticket)
        {
            if (ticket.Type == "General Inquiry")
            {
                Console.WriteLine("Obsługa ogólnego zapytania: " + ticket.Description);
            }
            else if (Successor != null)
            {
                Successor.HandleTicket(ticket);
            }
        }
    }
}
