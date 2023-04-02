using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООТПиСП_ЛР4
{
    internal class Printer
    {
        Interface obj;
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
