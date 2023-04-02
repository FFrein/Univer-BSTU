using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7_Обобщения
{
    internal partial class Date<T>
    {
        public T hour { get; set; }

        T minute { get; set; }

        T Day { get; set; }

        T Month { get; set; }

        T Year { get; set; }


        public Date(T y, T d, T mn, T mnth, T h)
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
