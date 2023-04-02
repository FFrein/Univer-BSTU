using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __19_20_Применение_структурных_и_паттернов_поведения
{
    public class FlightCrewType2 : ABSFlightCrew
    {
        public void Operation()
        {
            Console.WriteLine("Второй вид создание лётной команды // для патерна Bridge");
        }
        //https://metanit.com/sharp/patterns/4.6.php
        /*
        т.к. в патерне декоратор уже реализованн другой класс на основе AbsAirline
        мы можем создавать объект абстрактного класса AbsAirline на основе стандартного класса airline
        или на основе абстрактного класса AirlaneDecorator у которого есть конкретные классы:
        - ConcreteDecoratorB
        - ConcreteDecoratorA
        В этом файле реализован класс FlightCrewType2 с интерфейсом IDispatcher.
        Следовательно я могу сказать что патерн реализован т.к.
        Когда надо избежать постоянной привязки абстракции к реализации

        Когда наряду с реализацией надо изменять и абстракцию независимо друг от друга. 
        То есть изменения в абстракции не должно привести к изменениям в реализации
        */

    }
}
