using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООТПиСП5
{
    internal class Printer
    {
        public virtual void IAmPrinting(Object someobj)
        {
            Console.WriteLine(iIAmPrinting(someobj));
        }
        private string iIAmPrinting(Object someobj)
        {
            if (someobj is Receipt)
                return typeof(Receipt).ToString();
            if (someobj is Ticket)
                return typeof(Ticket).ToString();
            if (someobj is Invoice)
                return typeof(Invoice).ToString();
            return typeof(Interface).ToString();
        }
    }
}
