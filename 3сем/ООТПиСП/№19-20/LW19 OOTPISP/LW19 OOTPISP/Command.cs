using __19_20_Применение_структурных_и_паттернов_поведения;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW19_OOTPISP
{
    interface ICommand
    {
        public void ADD();
        public void Print(int num);
    }
    
    class CreateAirlineTypeOne : ICommand
    {
        AbsAirline airline; // Receiver - Получатель
        

        public CreateAirlineTypeOne()
        {
            airline = new Airline();

            airline.SetFlightsList(new FlightsList());

        }
        public void ADD()
        {
            AbsAirline.generator(airline, 1);
        }
        public void Print(int num)
        {
            ABSFlightCrew flc = airline.flightslist.GetFlight(num).GetFlightCrew();
            Console.WriteLine("Pilot: " + flc.GetPilot());
        }
    }
    class CreateAirlineTypeTwo : ICommand
    {
        AirlaneDecorator airline;
        public CreateAirlineTypeTwo()
        {
            airline = new ConcreteDecoratorA(new Airline());

        }
        public void ADD()
        {
            AbsAirline.generator(airline, 1);
        }
        public void Print(int num)
        {
            ABSFlightCrew flc = airline.flightslist.GetFlight(num).GetFlightCrew();
            Console.WriteLine("Pilot: " + flc.GetPilot());
        }
    }
    // Invoker - инициатор
    class AirlineInvoker
    {
        ICommand command;
        int counter_flights = 0;

        public AirlineInvoker() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressButton()
        {
            command.ADD();
            counter_flights++;
        }
        public void PressUndo(int num)
        {
            if (num >= counter_flights)
                Console.WriteLine("Error");
            else
                command.Print(num);
        }
    }
}
//https://metanit.com/sharp/patterns/3.3.php