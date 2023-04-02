using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innumerable_10_БГТУ_Мое_решение__
{

    class Podliva
    {
        static void Main(string[] args)
        {
            BSTUStudent student1 = new BSTUStudent(Specialization.poibms, "Vlad", 8, 2, 4, 4, 6, 5  );
            BSTUStudent student2 = new BSTUStudent(Specialization.poit, "Katya", 4, 3, 7, 4, 5, 5);
            BSTUStudent student3 = new BSTUStudent(Specialization.poibms, "Nikita", 8, 2, 6, 5, 6, 5);
            BSTUStudent student4 = new BSTUStudent(Specialization.poibms, "Kostya", 8, 2, 4, 4, 4, 4);
            BSTUStudent.Marks(student1);

            Groups mobilki = new Groups();
            mobilki.lAdd(student1);
            mobilki.lAdd(student2);
            mobilki.lAdd(student3);
            mobilki.lAdd(student4);

            //var average = mobilki.Array.Select((Mark1, Mark2) => Mark1 + Mark2).Sum() / ratings.Sum();

            //var maxAverage = (from t in mobilki.Array where t.Marks select t).Take(2);
            //Console.WriteLine(maxAverage);
        }
    }
}
