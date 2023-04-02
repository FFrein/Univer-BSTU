using LW3;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Обобщения
{
    static internal class MainClass
    {
        static void Main()
        {
            Date<string> date = new Date<string>("1", "1", "1", "1", "1");
            Document<Date<string>> doc = new Document<Date<string>>();
            Console.WriteLine(doc.String());
            doc.Add = date;
            LinkedList1<int> list1 = new LinkedList1<int>();
            list1.Add = 1;
            list1.Add = 2;
            list1.Add = 3;
            list1.Delete = 1;
            --list1;
            Console.WriteLine(list1.Watch);
            LinkedList1<int> list2 = new LinkedList1<int>();
            list2.Add = 1;
            LinkedList1<string> list3 = new LinkedList1<string>();
            list3.Add = "3";

            Console.WriteLine(list3.Contains("3"));
        }
    }
}
