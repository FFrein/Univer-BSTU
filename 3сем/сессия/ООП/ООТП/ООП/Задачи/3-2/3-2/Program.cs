using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    public class Location
    {
        public int lat { get; set; }
        public int longg { get; set; }
        public int speed { get; set; }

        public Location (int lat, int longg, int speed)
        {
            this.lat = lat;
            this.longg = longg;
            this.speed = speed;
        }
    }

    public class Taxi
    {
        public string number { get; set; }
        public Location location { get; set; }
        public enum Status
        {
            busy,
            free
        }
        public Status status;

        public Taxi(string number, Location location, Status status )
        {
            this.number = number;
            this.location = location;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{number} {location} {status}";

        }

    }

        public class Park<T> where T: Taxi
        {
            List<Taxi> park = new List<Taxi>();
            public void Add(Taxi obj)
            {
                park.Add(obj);
            }

            public void Del(Taxi obj)
            {

                park.Remove(obj);
            }

            public void Clear ()
            {
                park.Clear();
            }
            public string Find(Predicate<T> predicate)
            {
                foreach(T i in park)
            {
                if (predicate(i))
                {
                    return i.number;
                }
            }
            return null;
            }

        public override string ToString()
        {
            return $"{park}";
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Location location1 = new Location(14, 67, 60);
            Location location2 = new Location(34, 56, 65);
            Location location3 = new Location(58, 89, 70);
            Park<Taxi> uber = new Park<Taxi>();
            Taxi taxi1 = new Taxi("546", location1, Taxi.Status.busy);
            Taxi taxi2 = new Taxi("457", location2, Taxi.Status.free);
            Taxi taxi3 = new Taxi("523", location1, Taxi.Status.free);
            Taxi taxi4 = new Taxi("137", location3, Taxi.Status.busy);
            uber.Add(taxi1);
            uber.Add(taxi2);
            uber.Add(taxi3);
            uber.Add(taxi4);
            Console.WriteLine(uber.ToString());
            Predicate<Taxi> predicate = (Taxi tax) => { return tax.status == Taxi.Status.free; };
            Console.WriteLine(uber.Find(predicate));

        }
    }
}
