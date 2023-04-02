using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _17_18_Порождающие_паттерны_проектирования
{
   public class Programm
    {
        public static void Main()
        {
            //Заданеи 1
            Airline airline = new Airline();
            airline.SetFlightsList(new FlightsList());
            airline.generator(airline, 4);
            Console.WriteLine(airline.flightslist.GetFlight(2).GetFlightCrew().GetPilot());

            //Задание 2
            //Abstaract Factory и Builder

            //AF
            ClientFactory AirFuct = new ClientFactory(new ConcreteFactory1());
            AirFuct.Info();

            //B

            Builder builder = new AirlinesOneBuilder();
            Director director = new Director(builder);
            director.Construct();
            Airline airlineBuilder = builder.GetResult();


            //Задание 3
            //Singleton

            Singleton singleton;
            singleton = Singleton.getInstance("red", "14", "Arial");
            singleton = Singleton.getInstance("red2", "142", "Arial2");// не будет работать
            Console.WriteLine(singleton.BG_Color);

            //Задание 4
            //Prototype
            Prototype prototype = new ConcretePrototype1(1);
            Console.WriteLine("prototype.Id: " + prototype.Id);
            Prototype clone = prototype.Clone();
            Console.WriteLine("clone.Id: " + clone.Id);
            prototype = new ConcretePrototype2(2);
            Console.WriteLine("prototype.Id: " + prototype.Id);
            clone = prototype.Clone();
            Console.WriteLine("clone.Id: " + clone.Id);
        }
    }
}
//2, 5,6,7