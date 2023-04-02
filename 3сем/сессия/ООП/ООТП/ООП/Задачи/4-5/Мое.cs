using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Practice_Exam_3
{
    class Program
    {
        interface INumber
        {
             int Number { get; set; }
        }
        [Serializable]
        public class Bill : INumber
        {
            public int num;
            public Bill(int number)
            {
                this.Number = number;
            }
            public int Number
            {
                get
                {
                    return num;
                }
                set
                {

                    if ((value != 5 && value != 10 && value != 20 && value != 100) || value < 0)
                    {
                        throw new Error();
                        
                    }
                    else
                    {
                        num = value;
                    }


                }

            }
            
            public Bill()
            {

            }


            public override string ToString()
            {
                return base.ToString();

            }

        }

        [Serializable]
        public class Wallet<T> where T : Bill
        {
            List<T> money = new List<T>();

            public void Add(T obj)
            {
                if (money.Count > 200)
                {
                    throw new ToMuchMoney();
                }
                else
                {
                    money.Add(obj);
                }

            }

            public void Remove()
            {
                if (money.Count > 0)
                {
                    IEnumerable<T> delete = from i in money orderby i.Number select i;
                    money.Remove(delete.First());
                }
                else
                {
                    throw new NoBillWallet();
                }
            }
            public void Count()
            {

                var count = from i in money group i by i.Number;
                foreach (var i in count)
                {
                    Console.WriteLine($"{i.Key} {i.Count()}");
                }
            }
            
        }

        
        class ToMuchMoney : Exception
        {
            public ToMuchMoney() : base("To much money") { }

        }
        
        class NoBillWallet : Exception
        {
            public NoBillWallet() : base("No Bill in Wallet") { }

        }
        
        class Error : Exception
        {
            public Error() : base("ERROR") { }

        }



        static void Main(string[] args)
        {

            try
            {


                Wallet<Bill> wallet = new Wallet<Bill>();
                for (int i = 0; i < 10; i++)
                {
                    wallet.Add(new Bill(5));
                }
                for (int i = 0; i < 50; i++)
                {
                    wallet.Add(new Bill(10));
                }
                for (int i = 0; i < 10; i++)
                {
                    wallet.Add(new Bill(20));
                }
                for (int i = 0; i < 20; i++)
                {
                    wallet.Add(new Bill(100));
                }
                for (int i = 0; i < 111; i++)    // for (int i = 0; i < 112; i++) 
                {
                    wallet.Add(new Bill(100));
                }

                var binFormatted = new BinaryFormatter();

                using (var file = new FileStream("file.bin", FileMode.OpenOrCreate))
                {
                    binFormatted.Serialize(file, wallet);
                }

                //var XMLFormatted = new XmlSerializer(typeof(Wallet<Bill>));

                //using (var file = new FileStream("file.xml", FileMode.OpenOrCreate))
                //{

                //    XMLFormatted.Serialize(file, wallet);
                //    Console.WriteLine("Объект сериализован");
                //}

                //var jsonFormatted = new DataContractJsonSerializer(typeof(Wallet<Bill>));

                //using (var file = new FileStream("file.json", FileMode.Create))
                //{

                //    jsonFormatted.WriteObject(file, wallet);
                //}

                wallet.Count();
                wallet.Remove();
                Console.WriteLine("_______________________");
                wallet.Count();
                Console.WriteLine(wallet.ToString());
            }
            catch (ToMuchMoney err)
            {
                Console.WriteLine(err.Message);
            }
            catch (NoBillWallet err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Error err)
            {
                Console.WriteLine(err.Message);
            }
           



        }
    }
}
