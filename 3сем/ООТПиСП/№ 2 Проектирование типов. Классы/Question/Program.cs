//13
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AAA
{
    class A
    {
        private int _num;
        public A(int num) { Num = num; }
        public int Num { get { return _num; } set { _num = value; } }
    }
}

namespace Home
{
    class ControlMain
    {
        static void Main(string[] args)
        {
            AAA.A a = new AAA.A(5);
            AAA.A b = a;
            Console.WriteLine(a.Num + " " + b.Num);
            a.Num = 7;
            Console.WriteLine(a.Num + " " + b.Num);
        }
    }
}