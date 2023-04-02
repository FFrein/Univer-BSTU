using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_18_Порождающие_паттерны_проектирования
{
    ////////////////////////////////////////////////////////////////////////
    class Director
    {
        Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Airline GetResult();
    }
    /*
     Вместо этого класса использую класс Airline
    class Product
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
    */
    class AirlinesOneBuilder : Builder
    {
        Airline airline = new Airline();
        public override void BuildPartA()
        {
            airline.SetFlightsList(new FlightsList());
        }
        public override void BuildPartB()
        {
            airline.generator(airline, 1);
        }
        public override void BuildPartC()
        {
            Console.WriteLine(airline.flightslist.GetFlight(0).GetFlightCrew().GetPilot());
        }
        public override Airline GetResult()
        {
            return airline;
        }
    }
}

//https://metanit.com/sharp/patterns/2.5.php
