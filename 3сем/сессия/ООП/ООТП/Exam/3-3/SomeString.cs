using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace taska3_3
{
    
    public class SomeString : IComparer
    {
        private  string myString;
        public SomeString(){}
        public SomeString(string myString)
        {
            this.myString = myString;
        }
        public string MyString { get => myString; set => myString = value; }

        public int Compare(object x, object y)
        {
            int x1 = (int)x;
            int y1 = (int)y;
            if (x1 > y1)
                return 1;
            else if (x1 < y1)
                return -1;
            else
                return 0;
        }

        public override bool Equals(object myObj)
        {
            string obj = (string)myObj;

            if (obj.Length == MyString.Length)
            {
                if (obj[obj.Length - 1] == MyString[MyString.Length - 1])
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public static SomeString operator +(SomeString x, SomeString y)
        {
            try
            {
                if (x.MyString == "" || y.MyString == "" || x.MyString == null || y.MyString == null)
                    throw new ExClass();
                else
                {
                    SomeString rez = new SomeString();
                    rez.myString = x.myString + y.myString;
                    return rez;
                }
            }
            catch (ExClass ex)
            { 
                Console.WriteLine(ex.Message);
                SomeString rez = new SomeString();
                return rez;
            }
        }

        public static SomeString operator -(SomeString x, SomeString y)
        {
            try
            {
                if (x.MyString == "" || y.MyString == "" || x.MyString == null || y.MyString == null)
                    throw new ExClass();
                else
                {
                    SomeString rez = new SomeString();
                    for (int i = 1; i < x.MyString.Length; i++)
                    {
                        rez.MyString += x.MyString[i];
                    }
                    return rez;
                }
            }
            catch (ExClass ex)
            {
                Console.WriteLine(ex.Message);
                SomeString rez = new SomeString();
                return rez;
            }
        }

        public static void PrintToFile(string str)
        {
            using(StreamWriter stream = new StreamWriter(@"my.txt",true))
            {
                stream.WriteLine(str);
            }
        }

        public static void PrintToFile(int num)
        {
            using (StreamWriter stream = new StreamWriter(@"my.txt",true))
            {
                stream.WriteLine(num);
            }
        }
    }
}
