using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice_Exam_10
{
    public interface IClearnable
    {
        void Clearn();
    }

    public enum specialization { poit, isit, web, mobile }; 
    public class BSTUStudent
    {
        public string name;
        public int group;
        public specialization specialization;
        public int mark1;
        public int mark2;
        public int mark3;
        public int mark4;

        public BSTUStudent(string name, int group, specialization specialization, int mark1, int mark2, int mark3, int mark4)
        {
            this.name = name;
            this.group = group;
            this.specialization = specialization;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
            this.mark4 = mark4;
        }

        public static (int min, int max, int avr) Getmarks(BSTUStudent obj)
        {

            var result = (min: 0, max: 0, avr: 0);
            int[] nums = new int[4];
            nums[0] = obj.mark1;
            nums[1] = obj.mark2;
            nums[2] = obj.mark3;
            nums[3] = obj.mark4;
            result.max = nums.Max();
            result.min = nums.Min();
            result.avr = (int)nums.Average();
            return result;
        }
        public override string ToString()
        {
            return ("Имя " + name + " Группа " + group + " Специальность " + specialization);
        }

        
    }

    public class STGroup : IClearnable
    {
        ArrayList list = new ArrayList();

        public ArrayList GetList
        {
            get
            {
                return list;
            }
        }
        public void Add(object obj)
        {
            list.Add(obj);
        }
        public void Remove(object obj)
        {
            list.Remove(obj);
        }

        public void Clearn()
        {
            list.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BSTUStudent student1 = new BSTUStudent("Arsenii", 6, specialization.poit, 6, 7, 8, 5);
            BSTUStudent student2 = new BSTUStudent("Dima", 4, specialization.poit, 4, 5, 8, 8);
            BSTUStudent student3 = new BSTUStudent("Dasha", 8, specialization.mobile, 4, 4, 4, 9);
            BSTUStudent student4 = new BSTUStudent("Shyra", 2, specialization.web, 7, 7, 7, 7);
            Console.WriteLine(student1.ToString());

           var tuple = BSTUStudent.Getmarks(student1);


            STGroup listic = new STGroup();
            listic.Add(student1);
            listic.Add(student2);
            listic.Add(student3);
            listic.Add(student4);
            foreach (BSTUStudent stud in listic.GetList)
            {
                Console.WriteLine(stud.name);
                Console.WriteLine(stud.group);
                Console.WriteLine(stud.specialization);
            }
            listic.Clearn();
            foreach (BSTUStudent stud in listic.GetList)
            {
                Console.WriteLine(stud.name);
                Console.WriteLine(stud.group);
                Console.WriteLine(stud.specialization);
            }


        }
    }
}
