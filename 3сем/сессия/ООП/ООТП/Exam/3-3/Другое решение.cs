using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace ConsoleApp1
{
   
    class Program
    {

        static void Main(string[] args)
        {
            using (System.IO.StreamWriter file =new StreamWriter("MyFile.txt")) {
                try
                {
                    string sstr = "h";
                    SomeString MyStr = new SomeString("Hello students and Unstudents");
                    MyStr.Equals("elloH");
                    SomeString SecondStr = new SomeString("d sd");
                    file.WriteLine(MyStr.Compare(MyStr, MyStr));
                    file.WriteLine(MyStr.Del());
                    file.WriteLine(SecondStr + sstr);
                    file.WriteLine(-SecondStr);
                    List<SomeString> list = new List<SomeString>();
                    list.Add(MyStr);
                    list.Add(SecondStr);
                    SomeString[] arr = new SomeString[]{MyStr,SecondStr };
                    var coll = arr.Where(x => x.MyString.Contains(' ')).Count();
                    Console.WriteLine(coll);
                }
                catch (MyException x)
                {
                    Console.WriteLine(x.Message);
                }
            } }
    }
    class SomeString : IComparer,IEnumerable<SomeString>
    {
        public string MyString;
        public override Boolean Equals(Object obj)
        {
            string o = (string)obj;
            if ((MyString.Length == o.Length) && (MyString[0] == o[MyString.Length - 1]))
            {
                Console.WriteLine("Строки равны");
                return true;
            }
            else Console.WriteLine("Строки Не равны");
            return false;
        }

        public int Compare(object x, object y)
        {
            if (x == y)
            {
                return 0;
            }
            return -1;
        }

        IEnumerator<SomeString> IEnumerable<SomeString>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public SomeString(string Mstr)
        {
            this.MyString = Mstr;
        }
        public static string operator +(SomeString x,string y)

        {
            return x.MyString + y;

        }
        public static string operator -(SomeString x)

        {
            if (x.MyString == null || x.MyString == "")
            {
                throw new MyException("");
               
            }
           string oo= x.MyString.Substring(1, x.MyString.Length-1);
          
            return oo;
        }

    }
    static class SString
    {
        public static int CountOfSpaces(this SomeString a)
        {
            int count = 0;
            for (int i=0;i<a.MyString.Length;i++)
            {
                if (a.MyString[i] == ' ')
                {
                    count++;
                }

            }
            return count;
        }

        public static string Del(this SomeString a)
        {
            string[] arr;
            arr = a.MyString.Split(',','.',';',':','-');
            return  String.Join("", arr);        }
    }
    class MyException:Exception
    {
        public MyException(string message) : base("ООП это круто")
        {

        }
       
    }
}

