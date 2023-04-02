using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __19_20_Применение_структурных_и_паттернов_поведения
{
    public abstract class ABSFlightCrew : IDispatcher
    {
        string Pilot;
        string RadioOperator;
        string Navigator;
        string FlightAttendants;
        public void SetFlightAttendants(string value)
        {
            this.FlightAttendants = value;
        }

        public void SetNavigator(string value)
        {
            this.Navigator = value;
        }

        public void SetPilot(string value)
        {
            this.Pilot = value;
        }

        public void SetRadioOperator(string value)
        {
            this.RadioOperator = value;
        }

        public string GetFlightAttendants()
        {
            return this.FlightAttendants;
        }

        public string GetNavigator()
        {
            return this.Navigator;
        }

        public string GetPilot()
        {
            return this.Pilot;
        }

        public string GetRadioOperator()
        {
            return this.RadioOperator;
        }
    }
    public class FlightCrew : ABSFlightCrew
    {

    }
    public class Flight
    {
        ABSFlightCrew flightcrew;

        public ABSFlightCrew GetFlightCrew()
        {
            return this.flightcrew;
        }
        public void SetFlightCrew(ABSFlightCrew fc)
        {
            this.flightcrew = fc;
        }
    }
    public class FlightsList : IAdministrator
    {
        List<Flight> flights = new List<Flight>();

        public Flight GetFlight(int number)
        {
            return flights[number];
        }

        public void SetFlight(Flight _flights)
        {
            this.flights.Add(_flights);
        }
    }
    public abstract class AbsAirline
    {
        public FlightsList flightslist;

        public FlightsList GetFlightsList()
        {
            return flightslist;
        }
        public void SetFlightsList(FlightsList _flightslist)
        {
            this.flightslist = _flightslist;
        }
        private static string GetRandomName()
        {
            string[] NameMass = {
                "Исмаил Муса Хусейн Бахит", "Насер Гази Мухаммад Адаидар",
                "Хишам Абдул Кадр Хиджаз", "Муджн Абд аль-Малик Мухаммад Ахмад",
                "Мазен Мухаммад Сулейман Фагха", "Саид Бадарна",
                "Абдул Азиз Умар","Ихие Санвар",
                "Крис Адель Ишад аль-Бандак","Ибрагим Шмасана"
            };
            string name;
            Random rnd = new Random();
            int value = rnd.Next(0, NameMass.Length);

            name = NameMass[value];

            return name;
        }

        public static void generator(AbsAirline airline, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Flight flight = new Flight();

                ABSFlightCrew flightCrew = new FlightCrew();
                flightCrew.SetPilot(GetRandomName() + (char)i);
                flightCrew.SetFlightAttendants(GetRandomName() + (char)i);
                flightCrew.SetNavigator(GetRandomName() + (char)i);
                flightCrew.SetRadioOperator(GetRandomName() + (char)i);

                flight.SetFlightCrew(flightCrew);

                airline.flightslist.SetFlight(flight);
            }

        }
    }
    //стандартный класс без модификаций
    public class Airline : AbsAirline
    {

    }
}



//определяет общий интерфейс для создания объектов в суперклассе