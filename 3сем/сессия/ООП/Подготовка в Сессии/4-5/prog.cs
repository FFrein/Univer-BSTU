using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

//https://metanit.com/sharp/tutorial/15.1.php linq

//https://metanit.com/sharp/tutorial/3.9.php 

//https://metanit.com/sharp/tutorial/3.38.php generic
namespace _4_5
{
    interface INumber
    {
        public int Number { get; set; }

    }
    public class Bill : INumber
    {
        public Bill() { }
        public Bill(int value) 
        {
        Number = value;
        }
        int _number;
        public int Number {
            get
            {
                return _number;
            }
            set
            {
                if(NumberChecker(value))
                    _number = value;
                else
                {
                    Console.WriteLine("Неподходящее значение");
                }
            }
        }

        public bool NumberChecker(int value)
        {
            int[] mass = { 5, 10, 20, 50, 100 };
            foreach (int num in mass)
                if (value == num)
                    return true;
            return false;
        }
    }
    public class Wallet<T> where T : Bill
    {
        public List<T> BList = new List<T>();

        public void ADD(T _bill)
        {
            if (_bill.Number >= 200)
                throw new Exception("ToMuchMoney");
            BList.Add(_bill);
        }
        public void Delete(T _bill)
        {
            T minBill = default;
            int counter = 0;
            int buff = 300;
            foreach(var bill in BList)
            {
                counter++;
                if (buff >= bill.Number && buff >= _bill.Number)
                {
                    buff = bill.Number;
                    minBill = bill;
                }
            }
            if (minBill != null)
                BList.Remove(minBill);
            else
            {
                throw new Exception("NoBillinWallet");
            }   
        }
    }
    public class Prog
    {
        public static void Main()
        {
            Wallet<Bill> wallet = new Wallet<Bill>();
            wallet.ADD(new Bill(20));
            wallet.ADD(new Bill(50));
            wallet.ADD(new Bill(5));
            wallet.ADD(new Bill(100));
            wallet.ADD(new Bill(10));
            wallet.ADD(new Bill(10));
            wallet.ADD(new Bill(555));

            wallet.Delete(new Bill(555));
            wallet.Delete(new Bill(5));

            foreach(var p in wallet.BList)
            {
                Console.WriteLine(p.Number);
            }
            //https://metanit.com/sharp/tutorial/15.6.php
            var bills = from bill in wallet.BList
                            group bill by bill.Number;

            int counter = 0;
            foreach (var elem in bills)
            {
                counter = 0;
                Console.Write(elem.Key + ": ");
                foreach (var value in elem)
                    counter++;
                Console.Write(counter + "\n");
            }

            string json = JsonSerializer.Serialize(wallet);
            Console.WriteLine(json);
        }
    }
}
