using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public interface IAction<T>
    {
        void Add(T obj);
        void Remove(T obj);
        void Clear();

        void Info();
    }

    class NullSizeCollection : SystemException
    {
        public NullSizeCollection(string message):base(message)
        {
            Console.WriteLine("Коллекция пуста");
        }
    }

    public class ExamCard<T>: IAction<T> where T: Student
    {
        List<T> ts = new List<T>();
        public List<T> Ts
        {
            get
            {
                return ts;
            }
        }
         void IAction<T>.Add(T obj)
        {
            ts.Add(obj);
        }

        void IAction<T>.Remove(T obj)
        {
            try
            {
                if (ts.Count() == 0)
                {
                    throw new NullSizeCollection("Коллекция пуста");
                }
                else
                    ts.Remove(obj);
            }
            catch (NullSizeCollection ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void IAction<T>.Clear()
        {
            try
            {
                if (ts.Count() == 0)
                {
                    throw new NullSizeCollection("Коллекция пуста");
                }
                else
                    ts.Clear();
            }
            catch (NullSizeCollection ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        void IAction<T>.Info()
        {
            foreach (var i in ts)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }

    public class Student
    {
        public string Name;
        public string Subject;
        public int Mark;

        public Student(string name, string subject, int mark)
        {
            this.Name = name;
            this.Subject = subject;
            this.Mark = mark;
        }

        public override string ToString()
        {
            return $"Name: {Name} Subject: {Subject} Mark: {Mark}" ;
        }

     
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Anna", "Math", 8);
            Student student2 = new Student("Katya", "History", 7);
            Student student3 = new Student("Vlad", "OAP", 3);
            ExamCard<Student> examcard = new ExamCard<Student>();
            IAction<Student> action = examcard;
            action.Add(student1);
            action.Add(student2);
            action.Add(student3);
            action.Info();
            //action.Remove(student1);
            //action.Info();
            var selectbymark = from i in examcard.Ts
                               where i.Mark >= 4
                               select i;
            foreach (var i in selectbymark)
            {
                Console.WriteLine(i.ToString());
            }
            double agv = 0;
            int count = 0;
            foreach (var i in selectbymark )
            {
                agv += i.Mark;
                count++;
            }

            agv = agv / count;
            Console.WriteLine(agv);



        }
    }
}
