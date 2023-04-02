using System;
using System.Text;
namespace ConsoleApplication10
{
    internal class ClassOne
    {
        static void Main()
        {

            Console.WriteLine("Задание 1 (Типы)");
            Console.WriteLine();
            //пункт а

            byte numb_byte = 127; // 8 бит
            numb_byte = Byte.Parse(Console.ReadLine());
            short numb_short = 32767; // 16 бит

            char stdchar = 'A'; // 16 бит

            int numb_int = 2147483647; // 32 бит
            uint numb_uint; // беззнаковое

            long numb_long = 9223372036854775807L; // 64 бит
            ulong numb_ulong;

            float numb_float = 1.4e-45f; // 32 бит от 1.4e-45f до 3.4e+38f)

            double numb_double = 4.9e-324; // 64 бит (от 4.9e-324 до 1.7e+308)

            decimal numb_decimal = 100;

            bool stdbool = true; //8 (в массивах), 32 (не в массивах используется int)


            // пункт b
            //янвое преобразование
            //(https://metanit.com/sharp/tutorial/20.4.php)
            numb_uint = (uint)numb_long;
            numb_byte = (byte)stdchar;
            numb_double = (double)numb_long;
            numb_ulong = (ulong)numb_float;
            stdbool = Convert.ToBoolean(numb_long);

            //неявное
            numb_uint = stdchar;
            numb_long = numb_byte;
            numb_double = numb_long;
            numb_float = numb_ulong;
            numb_int = numb_short;


            //пункт c (https://dir.by/developer/csharp/pack_unpack/)

            int quest_1C_1 = 39;
            Object obj = quest_1C_1;
            int quest_1C_2 = (int)obj;


            //пункт d
            //(https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables)
            var Var_obj = 14;


            //пункт e 
            //http://mycsharp.ru/post/47/2014_09_30_znachenie_null_nullable-tipy_operator___.html
            int? a = 1;
            int? b = null;
            Console.WriteLine(a ?? 3); // 1 (если а не тру или не существует, тогда 3)
            Console.WriteLine(b ?? 3); // 3


            //пункт f
            /*
            var quest_1f = "1F";
            quest_1f = 4;
            */
            /*
            Это не работает, потмоу что компилятор выводит нашей 
            переменной тип. Можно поменять значение переменной на тот
            же тип данных.
            */



            Console.WriteLine();
            Console.WriteLine("Задание 2(строки)");
            Console.WriteLine();
            //пункт a
            //https://docs.microsoft.com/ru-ru/dotnet/api/system.string?view=netcore-3.1#operators

            string str1 = "это строка один";
            string str2 = "строка два";

            //сравнение 
            int comp_res = string.Compare(str1, str2);

            //пункт b
            if (comp_res < 0)
                Console.WriteLine("Строка str1 перед строкой str2");
            else if (comp_res > 0)
                Console.WriteLine("Строка str1 стоит после строки str2");
            else
                Console.WriteLine("Строки str1 и str2 идентичны");

            //соединение 
            string str3 = str1 + str2;
            string str4 = string.Concat(str1, str2);

            //копирование
            //https://www.geeksforgeeks.org/c-sharp-copyto-method/
            char[] buff = new char[10];
            str1.CopyTo(0, buff, 0, 10); //начальная позиция, куда вставляем, начальная позиция buf, кол переносимых символов

            //разделение 
            string strfrsplt = "Этот текст был разделён на отдельные слова";
            string[] words = strfrsplt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string strFE in words)
            {
                Console.WriteLine(strFE);
            }

            //вставка подстроки в заданную позицию
            string strfrIns = "Раз два три ";
            string substr = "четыре";

            strfrIns = strfrIns.Insert(11, substr);
            Console.WriteLine(strfrIns);

            //вставки подстроки в заданную позицию c помощью интерполировании
            float numbfrfrmt = 9.9913F;
            //https://metanit.com/sharp/tutorial/7.5.php
            //тут используется интерполирование строк. Вместо {0} ставиться переменная numbfrfrmt. Если хотим ещё что то внести дальше будет {1} и т.д. и дрпругие переменные через запятую после numbfrfrmt
            String s = String.Format("Число {0} - было вставленно в данную строку.", numbfrfrmt);

            Console.WriteLine(s);

            //удаление подстроки из строки
            //https://metanit.com/sharp/tutorial/7.2.php
            //https://docs.microsoft.com/ru-ru/dotnet/api/system.string.remove?view=net-6.0
            string strrem = "Из этой строки будет удалено это слово: Какаду";
            Console.WriteLine(strrem);
            string substrrem = "Какаду";
            int n = strrem.IndexOf(substrrem);
            strrem = strrem.Remove(n, substrrem.Length);
            Console.WriteLine(strrem);

            //пункт c
            //https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-6.0
            string nullstr = null;
            string emptystr = "";
            bool emptySTR1 = string.IsNullOrEmpty(nullstr);
            bool emptySTR2 = string.IsNullOrEmpty(emptystr);

            //пункт d
            StringBuilder sb = new StringBuilder("ABC", 50);

            sb.Append(new char[] { 'D', 'E', 'F' });//добавит символы в конец строки
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            sb.AppendFormat("GHI{0}{1}", 'J', 'k');//тоже самое только через формат

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            sb.Insert(0, "Alphabet: "); //добавление с определённой позиции
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            sb.Replace('k', 'K');// замена определённой подстроки из строки
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());



            Console.WriteLine();
            Console.WriteLine("Задание 3(Массивы)");
            Console.WriteLine();
            //пункт a
            //https://metanit.com/sharp/tutorial/2.4.php
            //https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays

            int size1 = 5, size2 = 5;
            int[,] massXY = new int[size1, size2]; //создание двумерного массива 
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    massXY[i, j] = j;
                    Console.Write(massXY[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            //пункт b

            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string buff_3B = weekDays[0];
            weekDays[0] = weekDays[1];
            weekDays[1] = buff_3B;

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.Write(weekDays[i] + " ");
            }
            Console.Write("\n");

            //пункт с
            int[][] arr_3B = new int[3][];
            arr_3B[0] = new int[2];
            arr_3B[1] = new int[3];
            arr_3B[2] = new int[4];
            for (int i = 0; i < arr_3B.Length; i++)
            {
                for (int j = 0; j < arr_3B[i].Length; j++)
                {
                    massXY[i, j] = j;
                    Console.Write(massXY[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            //пункт d
            var ArrUntyp = new object[2];
            ArrUntyp[0] = "asdfasasf";
            ArrUntyp[1] = 12;
            Console.WriteLine(ArrUntyp[0]);
            Console.WriteLine(ArrUntyp[1]);



            Console.WriteLine();
            Console.WriteLine("Задание 4(Кортежи)");
            Console.WriteLine();
            //https://metanit.com/sharp/tutorial/2.19.php
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
            //https://habr.com/ru/post/573088/
            //пункт a
            (int, string, char, string, ulong) Kortesh = (19, "строка", 'A', "string", 123647687574L);
            //пункт b
            Console.WriteLine(Kortesh);
            Console.WriteLine(Kortesh.Item1);
            //пункт c
            int numb_4C = Kortesh.Item1;

            ulong numbFrK;

            (_, _, _, _, numbFrK) = Kortesh;
            Console.WriteLine(numbFrK);

            (int, string) Kort2 = (123213, "sAfasf");

            string WordfromKort2;
            int numbfromKort2;

            (numbfromKort2, WordfromKort2) = Kort2;
            Console.WriteLine(WordfromKort2);
            Console.WriteLine(numbfromKort2);
            //сравнение
            var tuple1 = (23, 36);
            var tuple2 = (17, 31);
            Console.WriteLine(tuple1 == tuple2);
            Console.WriteLine(tuple1 != tuple2);



            Console.WriteLine();
            Console.WriteLine("Задание 5(локальная функция)");
            Console.WriteLine();

            static (int?, int?, int, char) expempleFunc(int[] mass, string str) 
            {
                int arr_sum = 0;
                int? max = null;
                int? min = null;
                char letter;

                for (int i = 0; i < mass.Length; i++)
                    arr_sum += mass[i];
                for (int i = 0; i < mass.Length; i++)
                {
                    if (max == null || min == null)
                    {
                        max = mass[i];
                        min = mass[i];
                    }
                    if (mass[i] < min) min = mass[i];
                    if (mass[i] > max) max = mass[i];
                }

                letter = str[0];

                var tuple = (max, min, arr_sum, letter); 
                //
                return tuple;
            }

            int[] mass_5 = { 1, 2, 3 };
            string str_5 = "asdasf";

            Console.WriteLine(expempleFunc(mass_5, str_5));



            Console.WriteLine();
            Console.WriteLine("Задание 6( Работа с checked/unchecked)");
            Console.WriteLine();

            uint a_6 = uint.MaxValue;

            unchecked
            {
                Console.WriteLine(a_6 + 1);  // output: 0
            }

            try
            {
                checked
                {
                    Console.WriteLine(a_6 + 1);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
            }
        }
    }
}