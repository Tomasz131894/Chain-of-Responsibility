using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void HandleTicket(Ticket ticket);
    }
}
