using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class BillingInquiryHandler : Handler
    {
        public override void HandleTicket(Ticket ticket)
        {
            if (ticket.Type == "Billing Inquiry")
            {
                Console.WriteLine("Obsługa zapytania dotyczącego rozliczeń: " + ticket.Description);
            }
            else if (Successor != null)
            {
                Successor.HandleTicket(ticket);
            }
        }
    }
}
