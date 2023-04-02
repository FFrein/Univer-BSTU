using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_18_Порождающие_паттерны_проектирования
{
    internal interface IAdministrator
    {
        public void SetFlight(Flight fl);
        public Flight GetFlight(int number);
    }
    internal interface IDispatcher 
    {
        public void SetPilot(string value);
        public void SetNavigator(string value);
        public void SetRadioOperator(string value);
        public void SetFlightAttendants(string value);

        public string GetPilot();
        public string GetNavigator();
        public string GetRadioOperator();
        public string GetFlightAttendants();
    }
}
