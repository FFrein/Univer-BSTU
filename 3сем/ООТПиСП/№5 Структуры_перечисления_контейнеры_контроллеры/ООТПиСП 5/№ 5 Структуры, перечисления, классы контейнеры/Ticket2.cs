using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПиСП5
{
    partial class Ticket : Document
    {
        public Ticket(int? m = 0)
        {
            amount = m;
        }
    }
}
