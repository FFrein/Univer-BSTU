using LW19_OOTPISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace __19_20_Применение_структурных_и_паттернов_поведения
{
   public class Programm
    {
        public static void Main()
        {
            //Заданеи 1
            //Декоратор
            AirlaneDecorator airlineOne = new ConcreteDecoratorA(new Airline());
            airlineOne.Operation();

            //Мост
            Airline airlineTwo = new Airline();
            airlineTwo.SetFlightsList(new FlightsList());
            airlineTwo.GetFlightsList().SetFlight(new Flight());
            airlineTwo.GetFlightsList().GetFlight(0).SetFlightCrew(new FlightCrewType2());

            //Задание 2
            //Command
            AirlineInvoker ALI = new AirlineInvoker();
            ALI.SetCommand(new CreateAirlineTypeOne());
            ALI.PressButton();
            ALI.PressUndo(0);

            //Memento
            AirlineType3 airlineMem = new AirlineType3();
            airlineMem.SetFlightsList(new FlightsList());
            AbsAirline.generator(airlineMem, 1);
            AirlineHistory AirHist = new AirlineHistory();
            AirHist.History.Push(airlineMem.SaveState());
            airlineMem.RestoreState(AirHist.History.Pop());

            //Visitor
            ObjectStructure structure = new ObjectStructure();
            structure.Add(new ElementA());
            structure.Add(new ElementB());
            structure.Add(new ElementB());
            structure.Accept(new ConcreteVisitor1());
        }
    }
}