using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taska3_3
{
    public static class WorkClass
    {
        public static int CountSpace(this SomeString str)
        {
            int counter=0;
            for (int i = 0; i < str.MyString.Length; i++)
                if (str.MyString[i] == ' ')
                    counter++;
            return counter;
        }

        public static SomeString DellOther(this SomeString str)
        {
            SomeString rez = new SomeString();
            for (int i = 0; i < str.MyString.Length; i++)
            {
                if (str.MyString[i] == ' ' || str.MyString[i] == '.' || str.MyString[i] == ','
                    || str.MyString[i] == '-' || str.MyString[i] == '!' || str.MyString[i] == '?'
                    )
                    continue;
                else
                    rez.MyString += str.MyString[i];
            }
            return rez;
           
        }
    }
}
