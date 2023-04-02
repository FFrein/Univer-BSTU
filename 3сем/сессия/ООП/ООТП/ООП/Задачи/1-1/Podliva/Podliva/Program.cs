using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text.Json;
using System.Threading.Tasks;


namespace Podliva
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Rectangle> listochek = new List<Rectangle>();
            Rectangle rec1 = new Rectangle (22, 24, 22, 25, "синий" );
            Rectangle rec2 = new Rectangle(12, 14, 12, 15, "ыыы");
            Rectangle rec3 = new Rectangle(12, 14, 12, 15, "ааа");
            Rectangle rec4 = new Rectangle(12, 14, 1, 1, "сий");
            Rectangle rec5 = new Rectangle(12, 14, 12, 15, "сиий");
            Rectangle rec6 = new Rectangle(12, 14, 12, 15, "ний");
            listochek.Add(rec1);
            listochek.Add(rec2);
            listochek.Add(rec3);
            listochek.Add(rec4);
            listochek.Add(rec5);
            listochek.Add(rec6);
            
            rec2 = rec2 + 20;
            Console.WriteLine(rec2.h + rec2.l);
            /*from i in listochek orderby i.h orderby i.l  select i;*/
            var linq = listochek.OrderBy(t => t.h).OrderBy(t => t.l).Last();

            //foreach (var item in linq)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            Console.WriteLine(linq.ToString());
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Rectangle>(fs, rec1);
                Console.WriteLine("Data has been saved to file");

            }
        }
    }
}
