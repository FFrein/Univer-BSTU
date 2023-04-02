using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SomeString fStr = new SomeString("ШИЗА");
            SomeString sStr = new SomeString("КРУТО");
            if(fStr.Equals("ЗАМЕЧАТЕЛЬНО"))
               SomeString.PrintToFile("ПРАВИЛЬНО, сестра");
            else
                 SomeString.PrintToFile("ОШИБКА, брат");


             SomeString.PrintToFile(fStr.Compare(2,4));

            SomeString rez = fStr + sStr;
             SomeString.PrintToFile(rez.MyString);
            SomeString rez1 = fStr-sStr;
             SomeString.PrintToFile(rez1.MyString);

             SomeString.PrintToFile("Static Class: ");
            SomeString str = new SomeString("Hello my bro. How are you ? Now, we speak english, it is so good . Goodby my bro... ");
             SomeString.PrintToFile(str.CountSpace());
            SomeString cho = str.DellOther();
             SomeString.PrintToFile(cho.MyString);
            SomeString[] myArr = { fStr, sStr, str };
            var z = (from t in myArr select t.CountSpace()).Sum();
             SomeString.PrintToFile(z);




            
        }
    }
}
