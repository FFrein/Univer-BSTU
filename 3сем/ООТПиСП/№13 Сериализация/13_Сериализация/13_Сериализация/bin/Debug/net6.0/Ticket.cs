using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПиСП_ЛР4
{
    internal class Ticket : Document
    {
        int? amount;

        public Ticket(int m = 0)
        {
            amount = m;
        }
        public override string ToString()
        {
            return $"Object type: {typeof(Ticket)}\n amount:{amount}";
        }
    }
}
