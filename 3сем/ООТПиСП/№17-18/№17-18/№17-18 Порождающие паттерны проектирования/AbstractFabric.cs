using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_18_Порождающие_паттерны_проектирования
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA
    {
        protected Airline airline;
        public abstract void ArabTeam();
    }

    abstract class AbstractProductB
    {
        protected Airline airline;
        public abstract void BelTeam();
    }

    class ProductA1 : AbstractProductA
    {
        public override void ArabTeam()
        {
            airline = new Airline();
            Console.WriteLine("Авиарейс A1 создан");
        }
    }

    class ProductB1 : AbstractProductB
    {
        public override void BelTeam()
        {
            airline = new Airline();
            Console.WriteLine("Авиарейс B1 создан");
        }
    }

    class ProductA2 : AbstractProductA
    {
        public override void ArabTeam()
        {
            airline = new Airline();
            Console.WriteLine("Авиарейс A2 создан");
        }
    }

    class ProductB2 : AbstractProductB
    {
        public override void BelTeam()
        {
            airline = new Airline();
            Console.WriteLine("Авиарейс B2 создан");
        }
    }


    class ClientFactory
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public ClientFactory(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }
        public void Info()
        {
            abstractProductA.ArabTeam();
        }
    }
}
//https://metanit.com/sharp/patterns/2.2.php
