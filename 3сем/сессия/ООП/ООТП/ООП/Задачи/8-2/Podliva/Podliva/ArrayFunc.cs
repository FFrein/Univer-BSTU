using System;
using System.Collections.Generic;
using System.Text;

namespace Podliva
{
    public delegate string MyDelegate();
    
    class ArrayFunc<t>
    {
        public static string ToString()
        {
            return "Work";
        }
        new public static string GetHashCode()
        {
            return "Work";
        }
        public static Func<int, int>[] funcs = new Func<int, int>[3];


       
    }
}
