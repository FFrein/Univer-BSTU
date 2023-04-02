using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;//для обработки ошибок с помощью Debug
//Разрешает взаимодействие с отладчиком. Этот класс не наследуется
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace ООТПиСП_6
{
    class TestClass
    {
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine($"Catch в Method1 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Method1");
            }
            Console.WriteLine("Конец метода Method1");
        }
        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Блок finally в Method2");
            }
            Console.WriteLine("Конец метода Method2");
        }
    }
    public class Home{
        static void Main(string[] args)
        {
            int index;
            index = -40;
           
            Debug.WriteLine("Entering Main");
            Console.WriteLine("Hello World.");
            Debug.Assert(index > -1, "We have some troubles");
            Debug.WriteLine("Exiting Main");

            Logger Log = new Logger();

            Log.CreatFile("Log.txt");

            //Ошибка для собственного класса
            try
            {
                Console.WriteLine("\n\n");
                Person Bob = new Person(13, "Alibaba");
                Person Bob2 = new Person(-13, "Alibaba");
                Person Bob3 = new Person(-2, "Alibaba");
            }
            catch (Exception ex)
            {
                Log.WriteInConsole(ex);
                Log.InputInFile(ex);
            }

            //Деление на 0
            int x = 0;
            int y = 1;
            try
            {
                Console.WriteLine("\n\n");
                int result1 = x / y;
                int result2 = y / x;
            }
            catch (DivideByZeroException ex) when (y == 0)
            {
                Log.InputInFile(ex);
                Log.WriteInConsole(ex);
            }
            catch (DivideByZeroException ex)
            {
                Log.InputInFile(ex);
                Log.WriteInConsole(ex);
            }
            //Неверный индекс
            try
            {
                Console.WriteLine("\n\n");
                int[] mass = { 1, 2, 3, 4 };
                Console.WriteLine(mass[5]);
            }
            catch (Exception ex)
            {
                Log.WriteInConsole(ex);
                Log.InputInFile(ex);
            }
            //Ошибка при работе с файлом
            try
            {
                Console.WriteLine("\n\n");
                string path = "123";
                FileInfo fileInfo = new FileInfo(path);
                Console.WriteLine($"Размер: {fileInfo.Length}");
            }
            catch (Exception ex)
            {
                Log.WriteInConsole(ex);
                Log.InputInFile(ex);
            }
            //поиск соответствующего обработчика исключения в стеке вызовов
            try
            {
                Console.WriteLine("\n\n");
                TestClass.Method1();
            }
            catch (DivideByZeroException ex)
            {
                Log.WriteInConsole(ex);
                Log.InputInFile(ex);
            }
            //множественная обработка исключений
            string[] str = new string[5];
            try
            {
                str[6] = "anything";
                Console.WriteLine("It's OK");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("This statement is always executed.");
            }
        }
    }
}
//https://metanit.com/sharp/tutorial/5.4.php работа с файловым потоком
//https://habr.com/ru/post/231585/
//https://learn.microsoft.com/ru-RU/dotnet/api/system.indexoutofrangeexception?view=net-6.0
//https://learn.microsoft.com/ru-ru/dotnet/standard/exceptions/how-to-use-finally-blocks
//https://metanit.com/sharp/tutorial/3.17.php
//https://learn.microsoft.com/ru-ru/dotnet/api/system.exception?view=netframework-4.8
