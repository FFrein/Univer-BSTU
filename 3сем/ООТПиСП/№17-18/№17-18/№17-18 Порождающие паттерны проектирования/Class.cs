using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_18_Порождающие_паттерны_проектирования
{
    public class FlightCrew : IDispatcher
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
    public class Flight
    {
        FlightCrew flightcrew;

        public FlightCrew GetFlightCrew()
        {
            return this.flightcrew;
        }
        public void SetFlightCrew(FlightCrew fc)
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
    public class Airline
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

        private string GetRandomName()
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

        public void generator(Airline airline, int amount)
        {
            for (int i =0; i < amount; i++) {
                Flight flight = new Flight();

                FlightCrew flightCrew = new FlightCrew();
                flightCrew.SetPilot(GetRandomName() + (char)i);
                flightCrew.SetFlightAttendants(GetRandomName() + (char)i);
                flightCrew.SetNavigator(GetRandomName() + (char)i);
                flightCrew.SetRadioOperator(GetRandomName() + (char)i);

                flight.SetFlightCrew(flightCrew);

                airline.flightslist.SetFlight(flight);
            }
  
        }
    }
}



//определяет общий интерфейс для создания объектов в суперклассе