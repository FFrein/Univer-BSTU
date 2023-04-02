using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __19_20_Применение_структурных_и_паттернов_поведения
{

    abstract class AirlaneDecorator : AbsAirline
    {
        protected AbsAirline absAirline;
        public AirlaneDecorator(AbsAirline absAirline)
        {
            this.absAirline = absAirline;
        }
        public virtual void Operation() { }
    }
    class ConcreteDecoratorA : AirlaneDecorator
    {
        public ConcreteDecoratorA(AbsAirline airline) : base(airline)
        {
            this.absAirline = airline;
        }
        public override void Operation()
        {
            Console.WriteLine("Особенность декоратора А");
        }
    }
    class ConcreteDecoratorB : AirlaneDecorator
    {
        public ConcreteDecoratorB(AbsAirline airline) : base(airline)
        {
            this.absAirline = airline;
        }
        public override void Operation()
        {
            Console.WriteLine("Особенность декоратора Б");
        }
    }
}
//https://metanit.com/sharp/patterns/4.1.php