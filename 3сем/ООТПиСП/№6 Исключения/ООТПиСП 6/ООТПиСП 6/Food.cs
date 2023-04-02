using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ООТПиСП_6
{
    public class Food : Exception
    {
        string? Name { get; set; }
        int Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Incorrect price");
                else
                    Price = value;
            }
        }
        int Amount
        {
            get
            {
                return Amount;
            }
            set
            {

                if (value < 0)
                throw new Exception("Incorrect amount");
                else
                    Amount = value;
            }
        }
        static int Division(int amount, int div)
        {
            if (div < 0)
                throw new Exception("Division by 0");
            return amount / div;
        }
    }
}
