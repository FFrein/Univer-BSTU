using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Students
    {
        public int mark;
        public string name;
        public string subject;
        public Students(string Name, int Mark, string Subject)
        {
            this.name = Name;
            this.mark = Mark;
            this.subject = Subject;
        }
        public Students()
        {

        }
        public override string ToString()
        {
            return mark + " " + name + " " + subject;
        }
    }

    interface IAction<T>
    {
        void Add(T a);
        void Del(T a);
        void Clean();
        void Show();

    }
    class ExamCard<T> : IAction<T> where T : new()
    {

        public static List<T> list = new List<T>();

        public void Add(T a)
        {
            list.Add(a);

        }
        public void Del(T a)
        {

            try
            {
                if (list.Count == 0)
                {
                    throw new NullSizeCollection("Коллекция пустая");
                }
                else list.Remove(a);
            }
            catch (NullSizeCollection ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Clean()
        {
            try
            {
                if (list.Count == 0)
                {
                    throw new NullSizeCollection("Коллекция пустая");
                }
                else list.Clear();
            }
            catch (NullSizeCollection ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Show()
        {
            Console.WriteLine("Вся коллекция: ");
            foreach (var l in list)
                Console.WriteLine(l);
        }
    }
    class NullSizeCollection : Exception
    {
        private string message;
        public override string Message
        {
            get
            {
                return message;
            }
        }
        public NullSizeCollection(string mess)
        {

            message = mess;
        }
    }



    static class Met
    {
        public static void qwe(this Students st)
        {
            Random random = new Random();
            st.mark += random.Next(1, 3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students st1 = new Students("qwe", 6, "rer");
            Students st2 = new Students("qwe", 7, "rer");
            Students st3 = new Students("qwe", 5, "rer");
            Students st4 = new Students("qwe", 3, "rer");
            ExamCard<Students> st = new ExamCard<Students>();
            ((IAction<Students>)st).Add(st1);
            ((IAction<Students>)st).Add(st2);
            ((IAction<Students>)st).Add(st3);
            ((IAction<Students>)st).Add(st4);
            ((IAction<Students>)st).Show();
            ((IAction<Students>)st).Del(st3);


            var linq1 = from s in ExamCard<Students>.list
                        where s.mark >= 4
                        select s;
            Console.WriteLine(linq1.Count());
            var linq2 = from s in ExamCard<Students>.list
                        select s.mark;
            Console.WriteLine(linq2.Average());

            st1.qwe();
            Console.WriteLine(st1);

        }
        
    }
}
