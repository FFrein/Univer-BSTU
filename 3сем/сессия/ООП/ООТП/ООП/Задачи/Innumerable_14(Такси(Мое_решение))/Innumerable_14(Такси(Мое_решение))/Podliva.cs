using System;

namespace Innumerable_14_Такси_Мое_решение__
{
    class Podliva
    {
        static void Main(string[] args)
        {
            Park<Taxi> uber = new Park<Taxi>();
            Console.WriteLine("Enter the location");
            double lat_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the location");
            double long_b = Convert.ToDouble(Console.ReadLine());
            double[] range = new double[3];

            Taxi car1 = new Taxi();
            car1.Number = "8805553535";
            Location loc1 = new Location(20, 25, 100);
            car1.Location = loc1;
            car1.Status = Status.free;
            range[0] = Math.Sqrt(Math.Pow(car1.Location.Lat - lat_b,2)+ Math.Pow(car1.Location.Long - long_b, 2));

            Taxi car2 = new Taxi();
            car2.Number = "332281447";
            Location loc2 = new Location(25, 30, 120);
            car2.Location = loc2;
            car2.Status = Status.busy;
            range[1] = Math.Sqrt(Math.Pow(car2.Location.Lat - lat_b, 2) + Math.Pow(car2.Location.Long - long_b, 2));

            Taxi car3 = new Taxi();
            car3.Number = "291654914";
            Location loc3 = new Location(0, 5, 100);
            car3.Location = loc3;
            car3.Status = Status.busy;
            range[2] = Math.Sqrt(Math.Pow(car3.Location.Lat - lat_b, 2) + Math.Pow(car3.Location.Long - long_b, 2));

            Array.Sort(range);
            foreach (double i in range)
            {
                Console.WriteLine(i);
            }

            uber.tAdd(car1);
            uber.tAdd(car2);
            uber.tAdd(car3);

            Console.WriteLine();
            Predicate<Taxi> find = (Taxi tax) => { return tax.Status == Status.free; };
            Console.WriteLine(uber.Find(find));

        }
    }
}
