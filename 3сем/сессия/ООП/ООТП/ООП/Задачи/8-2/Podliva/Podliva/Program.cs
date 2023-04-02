using System;

namespace Podliva
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate[] delegates = new MyDelegate[2];

            delegates[0] = ArrayFunc<string>.ToString;
            delegates[1] = ArrayFunc<string>.GetHashCode;
            ArrayFunc<string>.funcs[0] = i => i + 1;
            ArrayFunc<string>.funcs[1] = i => i * 2;
            ArrayFunc<string>.funcs[2] = i => i - 3;
            foreach (Func<int, int> func in ArrayFunc<string>.funcs)
            {
                Console.WriteLine(func(2));
            }



        }
    }
}
