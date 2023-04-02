using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class OwnNotWorking: Exception
    {
        public OwnNotWorking(string message): base(message)
        {
            Console.WriteLine("OwnNotWorking");
        }
    }
    interface ICookable
    {
        void Cook();
        void Check();
    }
    abstract class Device
    {
        int number { get; set; }
        string name { get; set; }

    }

     class Own: Device, ICookable
    {
        public int Temp { get; set; }
        public int Time { get; set; }
        public Status status;
       public  enum Status
        {
            ready = 1,
            cooking,
            finish
        }


        public Own()
        {
        }

        void ICookable.Cook()
        {
            string way = @"D:\text.txt";
            using (StreamWriter sw = new StreamWriter(way, false, System.Text.Encoding.Default))
            {
                if (status == Status.cooking)
                    sw.WriteLine("Cooking");
                else if (status == Status.ready)
                    sw.WriteLine("Ready");
                else
                    sw.WriteLine("Finish");
            }
        }

        void ICookable.Check()
        {
            if (Temp == 0 && Time > 0)
                this.status = Status.ready;
            
            if (Temp > 0 && Time > 0)
                this.status = Status.cooking;
            if (Temp > 0 && Time == 0)
                this.status = Status.finish;
        }

        public override string ToString()
        {
            return $" {Time} {Temp} {status} ";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {

                List<Own> owns = new List<Own>();
                Own own1 = new Own();
                Own own2 = new Own();
                own1.Temp = 70;
                own1.Time = 15;
                own1.status = Own.Status.cooking;
                own2.Temp = 60;
                own2.Time = 0;
                own2.status = Own.Status.cooking;
                owns.Add(own1);
                owns.Add(own2);

                var select = from i in owns
                             where i.status == Own.Status.cooking
                             select i;
            int count = 0;
                foreach (var i in select)
                {
                    count++;
                    Console.WriteLine(count);
                }

            ((ICookable)own2).Check();
            ((ICookable)own2).Cook();
            foreach (var a in owns)
            {
                try
                {
                    if (a.status == Own.Status.finish || a.status == Own.Status.ready)
                    {
                        throw new OwnNotWorking("Exception");
                    }
                }
                catch(OwnNotWorking ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
