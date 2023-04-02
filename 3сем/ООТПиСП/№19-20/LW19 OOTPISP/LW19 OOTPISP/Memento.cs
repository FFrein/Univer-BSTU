using __19_20_Применение_структурных_и_паттернов_поведения;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW19_OOTPISP
{
    public class AirlineType3 : AbsAirline
    {
        // сохранение состояния
        public AirlineMemento SaveState()
        {
            Console.WriteLine("Сохранение списка");
            return new AirlineMemento(flightslist);
        }

        // восстановление состояния
        public void RestoreState(AirlineMemento memento)
        {
            this.flightslist = memento.flightsList;
            Console.WriteLine("Восстановление списка");
        }
    }

    // Memento
    public class AirlineMemento
    {
        public FlightsList flightsList { get; private set; }
        public AirlineMemento(FlightsList flightsList)
        {
            this.flightsList = flightsList;
        }
    }
    // Caretaker
    public class AirlineHistory
    {
        public Stack<AirlineMemento> History { get; private set; }
        public AirlineHistory()
        {
            History = new Stack<AirlineMemento>();
        }
    }
}
//https://metanit.com/sharp/patterns/3.10.php