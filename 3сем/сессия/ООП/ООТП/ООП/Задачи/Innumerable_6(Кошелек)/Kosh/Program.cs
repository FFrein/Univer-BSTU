using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;

using System.Text;
using System.Threading.Tasks;

namespace Kosh

{
    [Serializable]
    class AddException : Exception
    {
        public AddException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }

    class DelException : Exception
    {
        public DelException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
    interface INumber
    {
        int Number { get; set; }
    }

    public class Bill : INumber
    {
        public Bill(int n)
        {
            Number = n;
        }
        public int number;
        public int Number
        {
            get { return number; }
            set
            {
                if (value != 5 && value != 10 && value != 20 && value != 30 && value != 40)
                    Console.WriteLine("Ошибка");
                else

                    number = value;
            }
        }

    }

    public class Wallet<T> where T : Bill
    {
        public List<Bill> wallet = new List<Bill>();

        public static int count = 0;
        public int AddToList(Bill obj)
        {
            wallet.Add(obj);
            count++;
            if (count < 200)
            {
                return count;
            }
            else
            {
                throw new AddException("Сумма купюр больше 200");
            }

        }
        public void DeleteFromList()
        {
            if (count > 0)
            {
                foreach (Bill a in wallet)
                {
                    var delete = from Bill in wallet orderby Bill.number select Bill;
                    wallet.Remove(wallet.First());
                }
            }
            else
            {
                throw new DelException("Нет купюр в кошельке");
            }
        }


        public void Count()
        {

            var count = from i in wallet group i by i.Number;
            foreach (var i in count)
            {
                Console.WriteLine($"{i.Key} {i.Count()}");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Wallet<Bill> wallet = new Wallet<Bill>();
                wallet.AddToList(new Bill(40));
                wallet.AddToList(new Bill(10));
                wallet.AddToList(new Bill(40));
                wallet.AddToList(new Bill(20));
                wallet.AddToList(new Bill(20));
                wallet.AddToList(new Bill(40));
                Console.WriteLine(wallet.ToString());
                wallet.Count();
               
            }

            catch(AddException err)
            {
                Console.WriteLine(err.Message);
            }

            catch (DelException err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}


