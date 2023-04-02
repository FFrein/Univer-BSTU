using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska7_3
{
    class ButtonCollection
    {
        public LinkedList<CheckButton> myList = new  LinkedList<CheckButton>();
        public void Add(CheckButton myButton)
        {
            myList.AddLast(myButton);
        }

        public void LinqSize(double Squer)
        {
            var squers = from t in myList where t.Squer() == Squer select t;
            foreach (var item in squers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
