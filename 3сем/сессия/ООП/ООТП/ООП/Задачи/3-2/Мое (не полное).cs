using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_Exam_6
{
    public enum Enumer { busy, free }

    class Location
    {
        public int lat { get; set; }
        public int longer { get; set; }
        public int speed { get; set; }

        public Location(int lat, int longer, int speed)
        {
            this.lat = lat;
            this.longer = longer;
            this.speed = speed;
        }
    }

    class Taxi
    {
        
        Location location;
        public string number;
        Enumer status;

        public Enumer Status
        {
            get
            {
                return status;
            }
        }

        public Taxi(Location loc,Enumer status,string number)
        {
        
            this.status = status;
            location = loc;
            this.number = number;

        }
        public override string ToString()
        {
            return (" Номер обьекта " + number + " Cтатус обьекта " + Status + " Тип обьекта " + location);
        }

    }

    class Park<T> where T : Taxi
    {
        List<T> list= new List<T>();
        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Delete(T obj)
        {
            list.Remove(obj);
        }
        public void Clear(T obj)
        {
            list.Clear();
        }
        public object Find(Predicate<T> predicate)
        {
           foreach( T item in list)
           {
                if (predicate(item))
                {
                    
                    return item;
                }
                

           }
            Console.WriteLine("Обьект найден");
            return null;
        }
        //public object Sort(T obj)
        //{
        //    foreach( T item in list)
        //    {

        //    }
        //}

    }


    class Program
    {
        static void Main(string[] args)
        {
            Park<Taxi> uber = new Park<Taxi>();
            Location location1 = new Location(5, 5, 5);
            Taxi machine1 = new Taxi(location1, Enumer.busy, "1111");
            Location location2 = new Location(6, 6, 6);
            Taxi machine2 = new Taxi(location2, Enumer.free, "1234");


            Predicate<Taxi> taxipredicate = (Taxi status) => { return status.Status == Enumer.free; };
            using (StreamWriter st = new StreamWriter(@"Text.txt"))
            {
                st.WriteLine(uber.Find(taxipredicate));
                st.WriteLine(machine1.ToString());
                st.WriteLine("____________");
                st.WriteLine(machine2.ToString());
            }
           
            Console.WriteLine(machine1.ToString());
            Console.WriteLine("____________");
            Console.WriteLine(machine2.ToString());

        }
    }
}
