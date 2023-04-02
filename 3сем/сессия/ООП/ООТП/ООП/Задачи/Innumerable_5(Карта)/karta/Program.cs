using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karta
{
    class PinErrorException : Exception
    {
        public PinErrorException(string message) : base(message)
        {
            Console.WriteLine("Пароль введен неверно");
        }
    }
    public class CreditCard: ICreditCard
    {
        public int balance;
        public int number;
        readonly int pin1;
        readonly int pin2;
        public int parm = 0;

        public CreditCard(int balance, int number, int pin1, int pin2)
        {
            this.balance = balance;
            this.number = number;
            this.pin1 = pin1;
            this.pin2 = pin2;
        }

        public void CheckBalabce()
        {
           while (true)
            {
                if (parm <3)
                {
                    try
                    {
                        Console.WriteLine("Введите pin1: ");
                        int pin1_1 = Convert.ToInt32(Console.ReadLine());
                        if (pin1_1 == pin1)
                        { 
                            Console.WriteLine("Баланс на карте: " + balance);
                            return;
                        }
                        else
                        {
                            parm++;
                            throw new PinErrorException("Неверный пароль");

                        }
                    }
                    catch (PinErrorException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Введите pin2: ");
                        int pin2_2 = Convert.ToInt32(Console.ReadLine());
                        if (pin2_2 == pin2)
                        {
                            Console.WriteLine("Баланс на карте: " + balance);
                            return;
                        }
                        else
                        {
                            throw new PinErrorException("Неверный пароль");
                        }
                    }
                    catch (PinErrorException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            
            
        }
        void ICreditCard.Add(int obj)
        {
            balance = this.balance + obj;
            Console.WriteLine("Баланс пополнен на: " + obj);
        }
        void ICreditCard.Get(int obj)
        {
            try
            {
                if (balance - obj > 0)
                {
                    balance = this.balance - obj;
                    Console.WriteLine("С карты сняли: " + obj);
                }
                else
                {
                    throw new Exception("Недостаточно средств");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    interface ICreditCard
    {
        void Add(int obj);
        void Get(int obj);
    }
        class Program
        {
            static void Main(string[] args)
            {
                CreditCard creditcard = new CreditCard(1200, 45600, 1234, 4321);
            CreditCard creditcard1 = new CreditCard(1560, 425670, 2234, 4322);
            CreditCard creditcard2 = new CreditCard(30, 412600, 3234, 4323);
            creditcard.CheckBalabce();
            ((ICreditCard)creditcard).Add(45);
            ((ICreditCard)creditcard).Get(400);
            List<CreditCard> creditcards = new List<CreditCard>();
            creditcards.Add(creditcard);
            creditcards.Add(creditcard1);
            creditcards.Add(creditcard2);

            var selectbymoney = from s in creditcards
                                where s.balance > 100 && s.number.ToString().Contains("2") && s.number.ToString().Contains("0")
                                select s.balance;
            int sum = 0;
            foreach (var s in selectbymoney)
                sum = +s;
            Console.WriteLine(sum);
        }
        }
    
}
