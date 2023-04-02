using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise_6
{
    static class Extension
    {
        public static Company DeleteInfo(this Company company)
        {
            company.Year1 = 0;
            company.Year2 = 0;
            company.Year3 = 0;
            company.Year4 = 0;

            return company;
        }

        public static(double max1, double max2) GetMax(this List<Company> list)
        {
            (double max1, double max2) tuple;
            tuple.max1 = ((IManage)list[0]).MaxAvg() / list[0].WorkerCount;
            tuple.max2 = ((IManage)list[1]).MaxAvg() / list[1].WorkerCount;
            double temp;
            foreach (Company i in list)
            {
                temp = ((IManage)i).MaxAvg() / i.WorkerCount;
                if (temp > tuple.max1)
                {
                    tuple.max1 = temp;
                }

            }
            foreach (Company i in list)
            {
                temp = ((IManage)i).MaxAvg() / i.WorkerCount;

                if (temp > tuple.max2 && temp != tuple.max1)
                {
                    tuple.max2 = temp;
                }
            }

            return tuple;
        }

    }
}
