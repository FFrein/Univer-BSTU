using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static LW8.Programmer;

namespace LW8
{
    class Programmer
    {
        private string WhoAmI = "Student";
        public delegate void SelfDestructHandler(string message);
        public event SelfDestructHandler SelfDestruct;

        public delegate void MutateHandler(string message);
        public event MutateHandler Mutate;

        public void RankUp()
        {
            if(WhoAmI == "Student")
            {
                WhoAmI = "Programmer";
                Mutate?.Invoke("Теперь ты раб 2 уровня\n");
            }
            else
            {
                WhoAmI = "Student";
                SelfDestruct?.Invoke("Ошибка, самоуничтожение\n");
            }
        }
    }

    delegate void AddPeopleHandler(string name, List<string> lst);

    //задание 2
    public delegate void Action(List<string> lst);
    public delegate bool Predicate<in T>(string str, List<string> lst);
    
    class ProgrammLW8
    {
        static void Main()
        {
            //Лаба
            //парт 1
            Programmer Nikita = new Programmer();
            Nikita.Mutate += (string message) => Console.WriteLine(message);
            Nikita.SelfDestruct += (string message) => Console.WriteLine(message);
            Nikita.RankUp();
            Nikita.RankUp();

            //chast 2
            List<string> Students = new List<string>() { "3.14", "Door", "Biba" }; ;
            List<string> Progrmist = new List<string>() { "SunХунь", "ЛиСиЦин", "VinХунь" };
            
            AddPeopleHandler AddStud = (string name, List<string> lst) =>
                lst.Add(name);

            AddStud("Boba", Students);

            foreach (var person in Students)
                Console.WriteLine(person);

            Console.WriteLine();

            AddStud = (string name, List<string> lst) =>
                lst.Add(name);

            AddStud("ЛиСиЦин", Progrmist);

            foreach (var person in Progrmist)
                Console.WriteLine(person);

            Console.WriteLine();

            Predicate<string> DelElem = (string str, List<string> lst) => lst.Remove(str);
            DelElem("ЛиСиЦин", Progrmist);

            foreach (var person in Progrmist)
                Console.WriteLine(person);

            Func<List<string>, string> ReturnLastElem = (List<string> lst) =>
            {
                return lst.Last();
            };

            Console.WriteLine();

            Console.WriteLine(ReturnLastElem(Progrmist));
            Console.WriteLine();

            Action WatchList = (List<string> lst) =>
            {
                foreach (var person in lst)
                    Console.WriteLine(person);
            };

            WatchList(Students);
        }
    }
}








/*
 Создать класс Программист с событиями Удалить и 
Мутировать. В main создать некоторое количество объектов
(списков). Подпишите объекты на события произвольным образом. 
Реакция на события может быть следующая: удаление 
первого/последнего элемента списка, случайное перемещение строк 
и т.п. Проверить результаты изменения состояния объектов после 
наступления событий, возможно не однократном
 */