using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roma
{
    public interface IAirble
    {
        void Check();
        void Fly();
    }
    public interface IAirable2
    {
        void Check();
    }
    internal enum Status { fly = 1, ready, stop}
    public abstract class Transport
    {
        public string Name;
    }
     class Air : Transport, IAirble, IAirable2
    {
        public int CountOfPassengers { get; set; }
        public int Speed { get; set; }
        private Status status;
        public Status Status { get => status; }

        public Air(string _name, int _CountOfPassengers, int _speed, Status _status)
        {
            this.Name = _name;
            this.CountOfPassengers = _CountOfPassengers;
            this.Speed = _speed;
            this.status = _status;
        }

        public void Check()
        {
            if (CountOfPassengers == 0 && Speed == 0)
                this.status = Status.stop;
            if (CountOfPassengers > 0 && Speed == 0)
                this.status = Status.ready;
            if (CountOfPassengers > 0 && Speed > 0)
                this.status = Status.fly;
        }
        public void Fly()
        {
            try
            {
                if (this.status == Status.fly)
                    Console.WriteLine("Flying");
                else
                    Console.WriteLine("Not flying");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void IAirable2.Check()
        {
            if (CountOfPassengers > 20 && CountOfPassengers < 100)
                Console.WriteLine("Ready");
        }
        public override string ToString()
        {
            return base.ToString() + " "  + Name + " " + CountOfPassengers + " " + Speed + " " + status;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string way = @"D:\Подливка\Сессия\2.0\ООП\Задачи\Innumerable_9\text.txt";
            using (StreamWriter sw = new StreamWriter(way, false, System.Text.Encoding.Default))
            {
                Air air1 = new Air("A167", 37, 0, Status.ready);
                Air air2 = new Air("B568", 0, 0, Status.stop);
                Air air3 = new Air("C569", 245, 164, Status.fly);
                Air air4 = new Air("D366", 234, 0, Status.ready);
                Air air5 = new Air("E355", 59, 160, Status.fly);
                sw.WriteLine(air1.ToString());
                sw.WriteLine(air2.ToString());
                sw.WriteLine(air3.ToString());
                air1.Check();
                air2.Check();
                air1.Fly();
                air3.Fly();
                IAirable2 airable = air1;
                IAirable2 airable2 = air3;
                airable.Check();
                airable2.Check();
                List<Air> list = new List<Air>();
                list.Add(air1);
                list.Add(air2);
                list.Add(air3);
                list.Add(air4);
                list.Add(air5);

                var select = from i in list
                             where i.Status == Status.fly
                             select i;
                int agv = 0;
                int count = 0;
                foreach (var i in select)
                {
                    agv += i.Speed;
                    count++;
                }
                agv = agv / count;
                sw.WriteLine($"Cредняя скорость: {agv}");
            }

            }
    }
}
