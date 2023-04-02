using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*1-2. Сделать абстрактный класс transport с вашей реализацией (я просто сделал string name). Наследовать его в классе Air.Добавить свойства CountOfPassengers и Speed,
а так же Status, который принимает значение из перечисления в классе с состояниями fly, ready, stop. Сделать интерфейс IAirable с методами Check() и Fly() и Наследовать его в Air.
Метод Check():
Если CountOfPassengers = 0 и Speed = 0, то Status = stop;
Если CountOfPassengers > 0 и Speed = 0, то Status = ready;
Если CountOfPassengers > 0, Speed > 0 и Status = ready, то Status = fly. Метод Fly() выводит Flying, если Status = fly, если нет - выбрасывает исключение
(можешь хоть базовое, я с сообщением делал). Продемонстрировать работу с объектом Air.
3. Сделать ВЕСЬ вывод еще и в файл.
4. Сделать интерфейс IAir... с таким же методом Check() и наследовать в Air. Метод из IAir... Должен выводить "Ready", если CountOfPassengers > 20 и <100. Продемонстрировать
оба метода в программе. (2 интерфейса, 2 метода но с 1 названием (IAir...Check(), IAirable.Check())).
5. Создать коллекцию из Air и добавить 5 объектов. С помощью linq запросов вывести количество самолетов, находящихся в Status = fly, а так же посчитать среднюю их скорость. 
*/

namespace Practice_Exam
{
    abstract class Transport
    {
        public string name;
    }

    interface IAirable
    {
        void Check();
        void Fly();

    }

    interface IAirability
    {
        void Check();
    }

    class Air : Transport, IAirable,IAirability
    {
        public int CountOfPassengers;
        public int Speed;
        public enum Status { ready, fly, stop };

        public Status st;


        void IAirability.Check()
        {
            string writePath = @"E:\ДОСДАТЬ\Practice_Exam\Practice_Exam\hta.txt";
            using (FileStream fs = new FileStream(writePath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    if (CountOfPassengers > 20 && CountOfPassengers < 100)
                    {

                        sw.WriteLine("READY");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }

        }

        void IAirable.Check()
        {
            string writePath = @"E:\ДОСДАТЬ\Practice_Exam\Practice_Exam\hta.txt";
            using (FileStream fs = new FileStream(writePath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    if (CountOfPassengers == 0 && Speed == 0)
                    {
                        st = Status.stop;
                        sw.WriteLine("Status now {0}", st);

                    }
                    else if (CountOfPassengers > 0 && Speed == 0)
                    {
                        st = Status.ready;
                        sw.WriteLine("Status now {0}", st);
                    }
                    else
                    {
                        st = Status.fly;
                        sw.WriteLine("Status now {0}", st);
                    }
                }
            }

        }

        public void Fly()
        {
            try
            {

                string writePath = @"E:\ДОСДАТЬ\Practice_Exam\Practice_Exam\hta.txt";
                using (FileStream fs = new FileStream(writePath, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        if (st == Status.fly)
                        {
                            sw.WriteLine("FLYING");
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.",e);
            }

        }

        public void show()
        {
            string writePath = @"E:\ДОСДАТЬ\Practice_Exam\Practice_Exam\hta.txt";
            using (FileStream fs = new FileStream(writePath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("All information about plane");
                    sw.WriteLine(this.name);
                    sw.WriteLine(this.CountOfPassengers);
                    sw.WriteLine(this.Speed);
                    sw.WriteLine(this.st);
                }
            }
           
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"E:\ДОСДАТЬ\Practice_Exam\Practice_Exam\hta.txt";

                Air airplane1 = new Air();
                airplane1.name = "BOING";
                airplane1.CountOfPassengers = 21;
                airplane1.Speed = 100;
                airplane1.st = Air.Status.fly;
                using (FileStream fs = new FileStream(writePath, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {

                        sw.WriteLine(airplane1.name);
                        sw.WriteLine(airplane1.CountOfPassengers);
                        sw.WriteLine(airplane1.Speed);
                        sw.WriteLine(airplane1.st);

                    }


                }
                
                airplane1.show();
                IAirability air1 = (IAirability)airplane1;
                air1.Check();
                IAirable air2 = (IAirable)airplane1;
                air2.Check();


            airplane1.Fly();
                

        }
    }
}
