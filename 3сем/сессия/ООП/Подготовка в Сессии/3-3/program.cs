using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public class SomeString : IComparable
    {
        public string str;

        public int CompareTo(object? obj)
        {
            if (str.Length > obj.ToString().Length)
                return 1;
            if (str.Length == obj.ToString().Length)
                return 0;
            if (str.Length < obj.ToString().Length)
                return -1;
            if (obj == null || str == null)
                throw new Exception("Invalid");
            return -100;
        }

        public override bool Equals(object? obj)
        {
            if (str.Length == obj.ToString().Length && 
                str[0] == obj.ToString()[0] &&
                str[str.Length - 1] == obj.ToString()[obj.ToString().Length - 1]
                )
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            return str;
        }
        //операции
        public static SomeString operator +(SomeString str1, SomeString str2)
        {
            return new SomeString { str = str1.str + str2.str };
        }
        public static SomeString operator -(SomeString str1, SomeString str2)
        {
            if (str1.str == "" || str1.str == null)
                throw new Exception("Invalid");
            return new SomeString { str = str1.str.Remove(0, 1) };
        }
    }
    //методы расширения
    public static class SomeStringExtension
    {
        public static int SpaceCount(this string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    counter++;
            }
            return counter;
        }
        public static string SymbolRemover(this string str)
        {
            char[] charsToRemove = { ',' ,'.' ,':' ,';' ,'-', '!'};
            foreach (char c in charsToRemove)
            {
                str = str.Replace(c.ToString(), String.Empty);
            }
            return str;
        }
    }
    public class Prog
    {
        public async static void WriteInFile(string str)
        {
            using(FileStream fs = new FileStream("File.txt", FileMode.OpenOrCreate))
            {
                byte[] buff = Encoding.Default.GetBytes(str);
                fs.Write(buff, 0, buff.Length);
            }
        }
        public static void Main()
        {
            string TextForFile = "";
            SomeString smstr1 = new SomeString();
            SomeString smstr2 = new SomeString();
            SomeString smstr3 = new SomeString();

            smstr1.str = "AsddfB";
            smstr2.str = "AssssB";
            smstr3.str = "AssssD";

            TextForFile +=(smstr1.Equals(smstr2)) + "\n";
            TextForFile +=(smstr1.Equals(smstr3)) + "\n";

            TextForFile +=(smstr1.CompareTo(smstr2)) + "\n";

            SomeString smstr4 = new SomeString();
            smstr4.str = "ASd.sdf : sdf ; sdg ear sf sdf, sdf! Zf - dsfsdf.";
            TextForFile +=(smstr4.str.SymbolRemover()) + "\n";
            TextForFile +=(smstr4.str.SpaceCount()) + "\n";

            TextForFile +=(smstr3 + smstr3) + "\n";
            TextForFile +=(smstr3 - smstr3) + "\n";

            //4

            SomeString[] smstrmass = { new SomeString(), new SomeString(), new SomeString(), new SomeString() };
            smstrmass[0].str = "asd  asf sdf sdf asf ";
            smstrmass[1].str = "s sdf asf s a asfd  ";
            smstrmass[2].str = "  asd as d   asd ";
            smstrmass[3].str = "sad   reg fh h ";

            var elems = from p in smstrmass
                        where p.str != null
                        let space_counter = p.str.SpaceCount()
                        select space_counter;

            int result = 0;
            foreach(var p in elems)
            {
                TextForFile +=(p) + "\n";
                result += p;
            }
            TextForFile +=("Общее число пробелов " + result) + "\n";
            WriteInFile(TextForFile);
        }
    }
}
