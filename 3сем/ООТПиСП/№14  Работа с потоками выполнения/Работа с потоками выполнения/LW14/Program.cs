using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LW14
{
    static class MyFunc
    {
        static int Square(int n) => n * n;
    }
    class Programm
    {
        public static void Task1()
        {
            //часть 1
            //отказано в доступе
            var AllProc = Process.GetProcesses();

            ProcessThreadCollection PTC;

            foreach (var proc in AllProc)
            {
                try
                {
                    Console.WriteLine("proc.Id: " + proc.Id);
                    Console.WriteLine("proc.ProcessName: " + proc.ProcessName);
                    Console.WriteLine("proc.BasePriority: " + proc.BasePriority);
                    Console.WriteLine("proc.StartTime: " + proc.StartTime);
                    Console.WriteLine("proc.TotalProcessorTime: " + proc.TotalProcessorTime);
                    Console.WriteLine("proc.Handle: " + proc.Handle);
                    Console.WriteLine("------------------------------------------------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        public static void Task2()
        {
            Console.WriteLine("\nподчасть 1\n");
            try
            {
                
                AppDomain domain = AppDomain.CurrentDomain;
                Console.WriteLine($"Name: {domain.FriendlyName}");
                Console.WriteLine($"SetupInformation: {domain.SetupInformation}");
                Console.WriteLine();

                Assembly[] assemblies = domain.GetAssemblies();
                foreach (Assembly asm in assemblies)
                    Console.WriteLine(asm.GetName().Name);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nподчасть 2\n");
            try
            {
                int number = 10;
                var context = new AssemblyLoadContext(name: "Square", isCollectible: true);
                // получаем путь к сборке LW14(namespace)
                var assemblyPath = Path.Combine(Directory.GetCurrentDirectory(), "LW14.dll");
                // загружаем сборку
                Assembly assembly = context.LoadFromAssemblyPath(assemblyPath);
                // получаем тип yFunc из сборки LW14.dll
                var type = assembly.GetType("LW14.MyFunc");
                // получаем метод Square
                var squareMethod = type.GetMethod("Square", BindingFlags.Static | BindingFlags.NonPublic);
                // вызываем метод
                var result = squareMethod?.Invoke(null, new object[] { number });
                //выводим результат
                Console.WriteLine($"\nКвадрат числа {number} равен {result}\n");
                // смотим, какие сборки у нас загружены
                Console.WriteLine("\nЗагруженные сборки: ");
                foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
                    Console.WriteLine(asm.GetName().Name);

                // выгружаем контекст
                context.Unload();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Task3()
        {
            async void Task3_1(object? n)
            {
                using (FileStream fr = new FileStream("Task3.txt", FileMode.OpenOrCreate))
                {
                    for (int i = 0; i < (int)n; i++)
                    {
                        Console.WriteLine(i.ToString());
                        byte[] buffer = Encoding.Default.GetBytes(i.ToString() + " ");
                        // запись массива байтов в файл
                        await fr.WriteAsync(buffer, 0, buffer.Length);
                        Thread.Sleep(10);//0.01 sec
                    }
                }
            }
            Thread Thread1 = new Thread(new ParameterizedThreadStart(Task3_1));
            Thread1.Start(100);
            Console.WriteLine("Thread Name: " + Thread1.Name);
            Console.WriteLine("Thread Priority: " + Thread1.Priority);
            Console.WriteLine("Thread ThreadState: " + Thread1.ThreadState);
        }
        public static void Task4()
        {
            var mutex = new Mutex();
            object Locker = new();

            async void Task4_1(object? obj)
            {
                if (obj != null)
                {
                    lock (Locker);
                    Thread.Sleep(10000);
                }
                    
                for (int i = 1; i < 30; i += 2)
                {
                    Console.WriteLine("Thread1: " + i.ToString());
                    if (obj == null)
                        mutex.WaitOne();
                    File.AppendAllText("Task3.txt", "Thread2: " + i.ToString() + "\n");
                    Thread.Sleep(10);//0.01 sec
                    if (obj == null)
                        mutex.ReleaseMutex();
                }
            }
            async void Task4_2(object? obj)
            {
                for (int i = 0; i < 30; i += 2)
                {
                    if (obj == null)
                        mutex.WaitOne();
                    Console.WriteLine("Thread2: " + i.ToString());
                    File.AppendAllText("Task3.txt", "Thread2: " + i.ToString() + "\n");
                    Thread.Sleep(200);//0.2 sec
                    if (obj == null)
                        mutex.ReleaseMutex();
                }
            }

            Thread Thread1_ii = new Thread(new ParameterizedThreadStart(Task4_1));
            Thread Thread2_ii = new Thread(new ParameterizedThreadStart(Task4_2));
            Thread1_ii.Start();
            Thread2_ii.Start();
            Thread1_ii.Join();
            Thread2_ii.Join();

            Thread.Sleep(2000);

            Thread Thread1_i = new Thread(new ParameterizedThreadStart(Task4_1));
            Thread Thread2_i = new Thread(new ParameterizedThreadStart(Task4_2));

            Thread1_i.Start(1);
            Thread2_i.Start(1);
            Thread1_i.Join();
            Thread2_i.Join();
        }
        public static void Task5()
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 2000);

            Console.ReadLine();

            static void Count(object obj)
            {
                int x = (int)obj;
                for (int i = 1; i < 9; i++, x++)
                {
                    Console.WriteLine($"{x * i}");
                }
            }
        }
            public static void Main()
        {
            //Task1();

            //Task2();

            //Task3();

            //Task4();

            Task5();
        }

    }
}