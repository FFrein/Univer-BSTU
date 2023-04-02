using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПиСП_ЛР4
{
    internal sealed partial class Date
    {
        int? hour { get; set; }

        int? minute { get; set; }

        int? Day { get; set; }

        int? Month { get; set; }

        int? Year { get; set; }


        public Date(int y = 0, int mnth = 0, int d = 0, int? h = 0, int? mn = 0)
        {
            minute = mn;
            hour = h;

            Day = d;
            Month = mnth;
            Year = y;
        }

        public override string ToString()
        {
            if(hour == null || minute == null)
                return $"{Day}.{Month}.{Year}";
            else
            return $"{hour}:{minute} {Day}.{Month}.{Year}";
        }
    }
}
