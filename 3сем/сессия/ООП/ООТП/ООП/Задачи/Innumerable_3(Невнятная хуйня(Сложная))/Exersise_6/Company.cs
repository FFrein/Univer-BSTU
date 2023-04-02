using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise_6
{
    enum Form
    {
        our = 1,
        your =2,
        my = 3
    }

    class Company : IManage
    {
        string _name;
        int _workerCount;
        Form _form;
        int _year1;
        int _year2;
        int _year3;
        int _year4;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int WorkerCount
        {
            get => _workerCount;
            set => _workerCount = value;
        }

        public Form Formm
        {
            get => _form;
            set => _form = value;
        }

        public int Year1
        {
            get => _year1;
            set => _year1 = value;
        }

        public int Year2
        {
            get => _year2;
            set => _year2 = value;
        }
        public int Year3
        {
            get => _year3;
            set => _year3 = value;
        }

        public int Year4
        {
            get => _year4;
            set => _year4 = value;
        }

        public (int max, int min) MaxMin()
        {
            (int Max, int Min) tuple = (0, _year1);
            List<int> vs = new List<int>();
            vs.Add(_year1);
            vs.Add(_year2);
            vs.Add(_year3);
            vs.Add(_year4);

            foreach(int y in vs)
            {
                if(y > tuple.Max)
                {
                    tuple.Max = y;
                }
                if(y < tuple.Min)
                {
                    tuple.Min = y;
                }
            }

            return tuple;
        }

        float IManage.MaxAvg()
        {
            float sum = 0;
            float result;
            sum = (float)(_year1 + _year2 + _year3 + _year4);
            result = sum / 4;

            return result;
        }

        public static Company operator ++(Company company)
        {
            company._workerCount++;
            return company;
        }

        public static Company operator --(Company company)
        {
            if (company._workerCount > 0)
            {
                company._workerCount--;
                return company;
            }
            throw new Exception("Ziro Exception");
        }

        public static Company operator +(Company company, int n)
        {
            company._workerCount = company._workerCount + n;
            return company;
        }

        

    }
}
