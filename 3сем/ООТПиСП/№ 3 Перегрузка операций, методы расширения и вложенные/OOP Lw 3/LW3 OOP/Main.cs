using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3_OOP
{
    internal static class Home
    {
        public static void Main()
        {

            LW3.LinkedList<string> List = new LW3.LinkedList<string>();
            // добавление элементов
            List.Add("One");
            List.Add("Two");
            List.Add("Three");
            Console.WriteLine("------");
            // выводим элементы
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            // удаляем элемент
            List.Remove("Two");
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            // проверяем наличие элемента
            bool isPresent = List.Contains("Four");
            Console.WriteLine(isPresent == true ? "Four присутствует" : "Four отсутствует");

            // добавляем элемент в начало            
            List.AppendFirst("Four");
            // выводим элементы
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            --List;
            // выводим элементы
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            LW3.LinkedList<string> List2 = new LW3.LinkedList<string>();
            List2.Add("2One");
            List2.Add("2Two");
            List2.Add("2Three");
            List = List2 * List;
            // выводим элементы
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            List += "asdasd";
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            LW3.StaticOperation.CheckDuplicate(List);
            Console.WriteLine("------");
            LW3.StaticOperation.UpperCaseCounter(List);
        }
    }
}
