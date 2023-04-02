using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
     interface IScore
            {
            int Amount { get; set; }
            int AddSum(int money);
            int RemSum(int money);
        }

        abstract class Human
        {
            public string DateofBirth { get; set; }
        }

        class Person : Human, IScore
        {
            public int Amount { get; set; } = 0;
            public int AddSum(int money)
            {
                return Amount += money;
            }
            public int RemSum(int money)
            {
                return Amount -= money;
            }

            static int count;
            public Person(string date){
                DateofBirth = date;
                count++;
            }

            static Person()
            {
                Console.WriteLine("Статический конструктор");
            }

            public static int CountObj()
            {
                return count;
            }

            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Person pers = (Person)obj;
                return (this.DateofBirth == pers.DateofBirth);
            }

        }

        class Bank : List<Person>
        {

        }
        static void Main(string[] args)
        {
            Person person1 = new Person("17.02.2000");
            Person person2 = new Person("17.03.2000");
            Person person3 = new Person("17.04.2000");
            Person person4 = new Person("17.02.2000");
            Console.WriteLine(Person.CountObj());
            person1.AddSum(10);
            person1.RemSum(4);
            Console.WriteLine(person1.Amount);
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person4));

            Bank belarus = new Bank();
            belarus.Add(person1);
            belarus.Add(person2);
            belarus.Add(person3);

            Bank alfa = new Bank();
            alfa.Add(person2);
            alfa.Add(person3);
            alfa.Add(person4);

            Bank vtb = new Bank();
            vtb.Add(person1);
            vtb.Add(person3);
            vtb.Add(person4);
        }
    }
}
