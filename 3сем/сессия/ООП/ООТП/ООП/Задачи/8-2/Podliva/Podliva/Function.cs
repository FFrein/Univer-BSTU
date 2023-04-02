using System;
using System.Collections.Generic;
using System.Text;

namespace Podliva
{
    abstract class Function
    {
        public double X { get; set; }
        public virtual double Func(double x, double c, double a, double b)
        {
            return a * x * x + b * x + c;
        }
        public virtual double Func(double x, double a, double b)
        {
            return a * x + b;
        }
    }
}
