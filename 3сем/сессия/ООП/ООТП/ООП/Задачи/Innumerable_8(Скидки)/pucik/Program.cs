using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pucik
{
    public interface IEnumerable
    { 
    }

    public class Item
    {
        public string name { get; set; }
        public int ID { get; set; }
        public double price { get; set; }

        public Item(string name, int ID, int price)
        {
            this.name = name;
            this.ID = ID;
            this.price = price;
        }

        public override string ToString()
        {
            return base.ToString() + " " + name + " " + ID + " " + price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void OnSale()
        {
            this.price -= this.price * 0.7;
            Console.WriteLine($"sale is now");
        }
    }
    public class Manager
    {
        public event _Sale sale;
        public void Sale()
        {
            if (sale != null)
                sale();
        }
    }
    public delegate void _Sale();
    public class Shop : IEnumerable
    {
        Queue<Item> queue = new Queue<Item>();

        public void Add (Item obj)
        {
            queue.Enqueue(obj);
        }

        public void Remove(Item obj)
        {
            queue.Dequeue();
        }
        public void Delete (Item obj)
        {
            queue.TrimExcess();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("shirt", 1236, 2000);
            Item item2 = new Item("dress", 3466, 1500);
            Item item3 = new Item("boots", 4578, 3000);
            Queue<Item> queue = new Queue<Item>();
            queue.Enqueue(item1);
            queue.Enqueue(item2);
            queue.Enqueue(item3);
            Console.WriteLine(item1.ToString());
            Console.WriteLine(item2.GetHashCode());
            foreach (Item a in queue)
            {
                Console.WriteLine(a);
            }
            Manager manager = new Manager();
            manager.sale += item1.OnSale;
            manager.sale += item3.OnSale;
            manager.Sale();
            foreach (Item a in queue)
                Console.WriteLine(a);
            Console.WriteLine();

        }
    }
}
