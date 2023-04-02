using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace _3_2
{
    public class Location
    {
        public int Lat;
        public int Long;
        public int Speed;
    }

    public class Taxi
    {
        public int Number;
        public string Name;
        public Location location = new Location();
        public Taxi(int number, string name, int x, int y, int speed, StatusList status)
        {
            Number = number;
            Name = name;
            location.Lat = x;
            location.Long = y;
            location.Speed = speed;
            this.status = status;
        }

        public enum StatusList
        {
            busy,
            free
        }
        public StatusList status;
    }

    public class Park<T>
    {
        public List<T> ElemetsList = new List<T>();

        public void Add(T elem)
        {
            ElemetsList.Add(elem);
        }
        public void Delet(T elem)
        {
            ElemetsList.Remove(elem);
        }
        public void Clear()
        {
            ElemetsList.Clear();
        }
        public bool Find(Predicate<T> fn, T a)
        {
            return fn(a);
        }
    }

    public class Prog
    {
        public static async void WriteFile(Park<Taxi> obj)
        {
            using (FileStream fs = new FileStream("File.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(obj.ElemetsList[0].Name);
                // запись массива байтов в файл
                await fs.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        public static void Main()
        {
            Park<Taxi> uber = new Park<Taxi>();

            Taxi taxi1 = new Taxi(11, "Axe", 40, 80, 20, Taxi.StatusList.free);
            Taxi taxi2 = new Taxi(12, "Rock", 20, 11, 50, Taxi.StatusList.busy);
            Taxi taxi3 = new Taxi(13, "Wood", 12, 50, 40, Taxi.StatusList.free);
            Taxi taxi4 = new Taxi(14, "Stone", 60, 30, 20, Taxi.StatusList.free);

            uber.Add(taxi1);
            uber.Add(taxi2);
            uber.Add(taxi3);
            uber.Add(taxi4);

            List<object> mixedList = new List<object>();

            Predicate<Taxi> a = (Taxi x) =>  x != null;

            Console.WriteLine( uber.Find(a, taxi4));

            foreach (var p in uber.ElemetsList)
            {
                Console.WriteLine(p.Name);
            }

            int PersonPosX = 20; //lat
            int PersonPosY = 11; //Long
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 4; j++)
                {
                    double elem1 = Math.Sqrt((PersonPosX - uber.ElemetsList[i].location.Lat) ^ 2 + (PersonPosY - uber.ElemetsList[i].location.Long) ^ 2);
                    double elem2 = Math.Sqrt((PersonPosX - uber.ElemetsList[j].location.Lat) ^ 2 + (PersonPosY - uber.ElemetsList[j].location.Long) ^ 2);
                    if (elem1 >= elem2)
                    {
                        var buff = uber.ElemetsList[i];
                        uber.ElemetsList[i] = uber.ElemetsList[j];
                        uber.ElemetsList[j] = buff;
                    }
                }

            Console.WriteLine();
            foreach (var p in uber.ElemetsList)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine("Lat " + p.location.Lat);
                Console.WriteLine("Long " + p.location.Long);
            }

            WriteFile(uber);
        }
    }
}
