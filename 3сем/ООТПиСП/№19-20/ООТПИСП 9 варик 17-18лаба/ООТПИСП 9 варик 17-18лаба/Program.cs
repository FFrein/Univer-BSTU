using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПИСП_9_варик_17_18лаба
{
    internal interface Administrator
    {
        public void AddToBlackList(Dictionary<int, string> Items, string Name) { }
        public void AddItem(Dictionary<int, string> Items, string Name) { }
        public void RemoveItem(Dictionary<int, string> Items, string Name) { }
    }
    internal interface ShopClient
    {
        public void CreateOrder() { }
        public void Pay() { }
    }
    public class InternetShop
    {
        public Admin admin;
        public Dictionary<int, string> Items;
        public InternetShop()
        {
            admin = new Admin();
            Items = new Dictionary<int, string>();
        }

    }
    public class Admin : Administrator
    {
        private int amount_items = 0;
        public Dictionary<string, string> BlackList = new Dictionary<string, string>();

        public void AddToBlackList(string Key, string Name)
        {
            BlackList.Add(Key, Name);
        }
        public void AddItem(Dictionary<int, string> Items, string Name)
        {
            Items.Add(amount_items++, Name);
        }
        public void RemoveItem(Dictionary<int, string> Items, string Name)
        {
            int counter = 0;
            foreach (var item in Items)
            {
                if (item.Value == Name)
                    Items.Remove(counter);
                counter++;
            }
        }
    }
    public class Client : ShopClient
    {
        int money;
        bool Order;
        string Name;
        public Client(int _money, string _name)
        {
            money = _money;
            Order = false;
            Name = _name;
        }
        private bool CreateOrderPrivate(InternetShop shop, string itemName)
        {
            bool ItemInDictionary = false;
            foreach (var item in shop.Items)
            {
                if (item.Value == itemName)
                    ItemInDictionary = true;
            }

            if (ItemInDictionary)
                return true;
            else
                return false;
        }
        public void CreateOrder(InternetShop shop, string itemName)
        {
            bool bancheck = false;
            foreach (var name in shop.admin.BlackList)
            {
                if (name.Value == Name)
                    bancheck = true;
            }
            if (bancheck)
            {
                Console.WriteLine("Вы забанены");
                return;
            }

            if (!Order)
            {
                if (CreateOrderPrivate(shop, itemName))
                {
                    Console.WriteLine("Ордер создан");
                    Order = true;
                }
                else
                    Console.WriteLine("Товар не найден");
            }
            else
            {
                Console.WriteLine("У вас есть неоплаченый ордер");
            }
        }
        public void Pay()
        {
            Order = false;
        }
    }

    /*
     *     public class main
    {
        public static void Main()
        {
            InternetShop internetShop = new InternetShop();

            internetShop.admin.AddItem(internetShop.Items, "Берцы");
            internetShop.admin.AddItem(internetShop.Items, "Автомат");
            internetShop.admin.AddItem(internetShop.Items, "Ноутбук");
            internetShop.admin.RemoveItem(internetShop.Items, "Ноутбук");

            Console.WriteLine("Товары в магазине");
            foreach (var item in internetShop.Items)
                Console.WriteLine(item.Value);
            Console.WriteLine('\n');

            Client Ilya = new Client(1000, "Ilya");
            Ilya.CreateOrder(internetShop, "Берцы");
            Ilya.CreateOrder(internetShop, "Автомат");
            Ilya.Pay();
            Ilya.CreateOrder(internetShop, "Несуществущий Итем");

            internetShop.admin.AddToBlackList("Anton","Kovalev");
            Client Anton = new Client(0, "Kovalev");
            Anton.CreateOrder(internetShop, "Берцы");
        }
    }
     */
    public class main
    {
        public static void Main()
        {
            int[] mass2 = { 109, 97, 121, 98, 101, 32, 121, 111, 117, 32, 109, 101, 97, 110, 116, 32, 116, 104, 105, 115, 58, 32, 117, 32, 9829, 32, 109, 101, 63, 32, 10, 98, 117, 116, 32, 116, 104, 101, 32, 105, 100, 101, 97, 32, 105, 115, 32, 118, 101, 114, 121, 32, 97, 109, 97, 122, 105, 110, 103 };
            foreach (int let in mass2) Console.Write((char)let);
        }
    }
}
