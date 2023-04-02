using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer

{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb1 = new int[] { 1, 2, 3, 4 };
            foreach (int i in numb1)
            {
                Console.WriteLine(i);
            }

            int[,] numb2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (int i in numb2)
            {
                Console.WriteLine(i);
            }


            int[][] nums = new int[3][];
            nums[0] = new int[3]{ 1,2,3};
            nums[1] = new int[2] { 4, 5 };
            nums[2] = new int[1] { 6 };
            foreach (int[] i in nums)
            {
                Console.WriteLine(i);
            }

            var tuple = (1, 3);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);




        }
    }
}
