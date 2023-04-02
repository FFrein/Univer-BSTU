using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckButton myButton1 = new CheckButton(States.checkeds, "Заголовок", new Pointer(2, 1));
            Console.WriteLine(myButton1);
            CheckButton myButton2 = new CheckButton(States.uncheckeds, "Заголовоки", new Pointer(3, 10));
            CheckButton myButton3 = new CheckButton(States.checkeds, "Заголовоки", new Pointer(1, 2));
            CheckButton myButton4 = new CheckButton(States.uncheckeds, "Заголовоки", new Pointer(4, 3));
            CheckButton myButton5 = new CheckButton(States.checkeds, "Заголовоки", new Pointer(2, 1));
            CheckButton myButton6 = new CheckButton(States.uncheckeds, "Заголовоки", new Pointer(7, 8));
            Console.WriteLine(myButton3.Equals(myButton1));
            myButton2.Zoom(150);
            Console.WriteLine(myButton2);
            User user = new User();

            user.Click += myButton1.Check;
            user.Click += myButton2.Check;
            user.Click += myButton3.Check;
            user.Resize += myButton4.Zoom;
            user.Resize += myButton5.Zoom;
            user.Resize += myButton6.Zoom;

            user.Events();
            Console.WriteLine(myButton2);


            ButtonCollection myList = new ButtonCollection();

            myList.Add(myButton1);
            myList.Add(myButton2);
            myList.Add(myButton3);
            myList.Add(myButton4);
            myList.Add(myButton5);
            myList.Add(myButton6);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            myList.LinqSize(myButton3.Squer());


            var count = (from t in myList.myList select t).Count();
            Console.WriteLine(count);



        }
    }
}
