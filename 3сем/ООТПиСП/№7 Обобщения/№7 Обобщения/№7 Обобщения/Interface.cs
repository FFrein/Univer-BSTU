using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Обобщения
{
    internal interface Interface<T>
    {
        T Add { set; }
        T Delete { set; }
        T Watch { get; }
    }
}
