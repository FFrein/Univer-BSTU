using System;
using System.Collections.Generic;
using System.Text;

namespace Innumerable_14_Такси_Мое_решение__
{
    enum Status
    {
        busy,
        free
    }
    class Taxi
    {
        public string Number { get; set; }
        public Location Location { get; set; }
        public Status Status { get; set; }
    }
}
