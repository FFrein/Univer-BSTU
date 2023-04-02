using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podliva
{
    class Podliva
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("Диван", 1, 32);
            Item item2 = new Item("Диван", 2, 40);
            Item item3 = new Item("Диван", 3, 30);
            Item item4 = new Item("Диван", 4, 36);

            Shop que = new Shop();
            que.qAdd(item1);
            que.qAdd(item2);
            que.qAdd(item3);
            que.qAdd(item4);

            Console.WriteLine(item1.ToString());
            Console.WriteLine(item1.GetHashCode());

            foreach (var item in que)
            {
                Console.WriteLine(item);
            }

            Manager manager = new Manager();
            manager.sales += item1.Start;
            manager.sales += item2.Start;
            manager.sales += item3.Start;
            manager.SaleOn();
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            string whatName = "Диван";
            var itemCount = (from t in que.queue where t.Name == whatName select t).Count();
            Console.WriteLine(itemCount);
             
        }
    }
}
