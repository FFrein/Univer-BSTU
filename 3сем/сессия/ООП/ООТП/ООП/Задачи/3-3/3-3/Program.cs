using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public class SomeString : IComparer<SomeString>
    {
        public string s;
        public SomeString(string s)
        {
            this.s = s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            SomeString str = (SomeString)obj;
            return (this.s.Length == str.s.Length && this.s[0] == str.s[0] && this.s.Substring(this.s.Length - 1) == str.s.Substring(str.s.Length - 1));

        }
        public int Compare(SomeString s1, SomeString s2)
        {
            if (s1.s.Length > s2.s.Length)
                return 1;
            else if (s1.s.Length < s2.s.Length)
                return -1;
            else return 0;
        }

        public static SomeString operator +(SomeString s1, char a1)
            {
            return new SomeString(s1.s + a1);
            }
        public static SomeString operator - (SomeString s2, char a2)
        {
            try
            {
                if (s2.s == null)
                    throw new Exception("Str is empty");
                    }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return new SomeString(s2.s = s2.s.Remove(0, 1));
        }

    }

    public static class StringExtention
    {
        public static int Count(this SomeString str)
        {
            int count = 0;
            foreach (var a in str.s)
            {
                if (a == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        public static string Remove(this SomeString str)
        {
            foreach (var a in str.s)
            {
                if (a == '.' || a == ',' || a== '!' || a== ';' ||  a== '-')
                {
                    str.s = str.s.Replace(a, ' ');
                }
            }
            return str.s;
        }

    }
        class Program
        {
        static void Main(string[] args)
        {

            string way = @"D:\СЕССИЯ\ООП\3-3\text.txt";
            using (StreamWriter stream = new StreamWriter(way, false, System.Text.Encoding.Default))
            {

                SomeString s1 = new SomeString("qw.erty");
                SomeString s2 = new SomeString("qw ert y");

                stream.WriteLine(s1.Compare(s1, s2));
                s1 = s1 + 'a';
                s2 = s2 - ' ';
                stream.WriteLine(s1.s);
                stream.WriteLine(s2.s);

                stream.WriteLine(StringExtention.Remove(s1));
                stream.WriteLine(StringExtention.Count(s2));
                SomeString[] somes = new SomeString[2];
                somes[0] = s1;
                somes[1] = s2;

                var select = from s in somes
                             where s.Count() > 0
                             select s;
                int sum = 0;
                foreach (var s in select)
                {
                    sum += s.Count();
                }

                stream.WriteLine(sum);
            }

        }
        }

    }