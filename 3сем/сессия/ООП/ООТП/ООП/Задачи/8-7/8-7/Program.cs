using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7
{
    public class AirPort
    {
        public AirPort()
        {
            airs = new List<Air>();
        }
        public List<Air> airs;
        public void Add(Air obj)
        {
            airs.Add(obj);
        }

        public void Remove(Air obj)
        {
            airs.Remove(obj);
        }
        public void Pilot(AirPort obj)
        {
            var select = from o in airs
                         orderby o.time
                         select o;
            foreach (var o in select)
            {
                Console.WriteLine(o);
            }
        }

    }
    public static class AirPortExtention
    {

        public static void Sort(this AirPort obj)
        {
            var selectbynumders = from t in obj.airs
                                  where t.pilot.number >= 100
                                  select t.pilot.number;
            foreach (var t in selectbynumders)
            {
                Console.WriteLine(t);
            }
        }
    }

    public class Pilot
    {
        public string name;
        public int number;

        public Pilot(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }

    public class Air : IComparable, IComparer<Air>
    {
        public string model { get; set; }
        public Pilot pilot { get; set; }
        public string napr { get; set; }
        public string time { get; set; }

        public Air(string model, Pilot pilot, string napr, string time)
        {
            this.model = model;
            this.pilot = pilot;
            this.napr = napr;
            this.time = time;
        }

        public override string ToString()
        {
            return base.ToString() + " " + model + " " + pilot + " " + napr + " " + time;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int Compare(Air air1, Air air2)
        {
            if (air1.pilot.name.Length < air2.pilot.name.Length)
                return -1;
            else if (air1.pilot.name.Length > air2.pilot.name.Length)
                return 1;
            else
                return 0;
        }
        public int CompareTo(object o)
        {
            Air air = o as Air;
            if (air != null)
                return this.time.CompareTo(air.time);
            else
                throw new Exception("Object is not a Air");
        }
    }

    class Program
    {


    static void Main(string[] args)
    {
        Pilot pilot1 = new Pilot("Anna", 129);
        Pilot pilot2 = new Pilot("Vlad", 97);
        Air air1 = new Air("vupsen", pilot1, "Москва", "12:15");
        Air air2 = new Air("pupsen", pilot2, "Санкт-Петербург", "12:14");
        Console.WriteLine(air1.CompareTo(air2));
        AirPort airport = new AirPort();
        airport.Add(air1);
        airport.Add(air2);
        airport.Sort();
        airport.Pilot(airport);


        }
}
}
