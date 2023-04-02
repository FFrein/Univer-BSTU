using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __19_20_Применение_структурных_и_паттернов_поведения
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
