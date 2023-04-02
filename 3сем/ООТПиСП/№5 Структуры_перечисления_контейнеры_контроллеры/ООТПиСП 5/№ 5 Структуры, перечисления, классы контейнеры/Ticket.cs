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
        public int? amount;
        public override string ToString()
        {
            return $"Object type: {typeof(Ticket)}\n amount:{amount}";
        }
    }
}
