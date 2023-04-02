using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innumerable_10_БГТУ_Мое_решение__
{
    
    enum Specialization
    {
        isit,
        poibms,
        poit,
        deivi
    }
    class BSTUStudent
    {
        public override string ToString()
        {
            return ("Имя " + Name + " Группа " + Group + " Специальность " + Specialization);
        }
        public string Name {get; set;}
        public int Group{get; set;}
        public int Course {get; set;}
        public Specialization Specialization { get; set;}
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public BSTUStudent(Specialization specialization, string name, int group, int course, int mark1, int mark2, int mark3, int mark4)
        {
            Specialization = specialization;
            Name = name;
            Group = group;
            Course = course;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
        }
        public static (int, int, double) Marks(BSTUStudent obj)
        {
            int[] marks = { obj.Mark1, obj.Mark2, obj.Mark3, obj.Mark4 };
            int max = marks.Max();
            int min = marks.Min();
            double average = marks.Average();
            var result = ( min, max, average);
            return result;
        }
    }
}
