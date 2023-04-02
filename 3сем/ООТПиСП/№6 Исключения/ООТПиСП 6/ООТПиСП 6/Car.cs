using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООТПиСП_6
{
    internal class Car : Exception
    {
        public string model { get; set; }
        public int Year_of_manufacture 
        {
            get
            {
                return Year_of_manufacture;
            }
            set
            {
                if (Year_of_manufacture < 1886)
                {
                    throw new Exception("The first machine was created on January 29, 1886");
                }
                else
                    Year_of_manufacture = value;
            }
        }
        public Car(string model, int year_of_manufacture)
        {
            this.model = model;
            this.Year_of_manufacture = year_of_manufacture;
        }
    }
}
