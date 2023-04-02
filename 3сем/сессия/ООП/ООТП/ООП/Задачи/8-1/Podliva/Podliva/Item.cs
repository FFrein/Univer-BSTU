using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podliva
{
    class Item 
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Price { get; set; }

        public Item(string name, int ID, double price)
        {
            Name = name;
            this.ID = ID;
            Price = price;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Name + " " + ID + " " + Price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void Start()
        {
            this.Price = this.Price * 0.5;
            Console.WriteLine("sale");
        }
    }
}
