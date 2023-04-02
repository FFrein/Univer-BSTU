using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    public interface IManage
    {
        float MaxAvg();
    }
    public enum Form
    {
        our = 1,
        your,
        my
    }
    public class ZiroException: Exception
    {
        public ZiroException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }

    public class Company: IManage
    {
        public string name { get; set; }
        public int count { get; set; }
        Form form { get; set; }
        public int year1 { get; set; }
        public int year2 { get; set; }
        public int year3 { get; set; }
        public int year4 { get; set; }


         public Company(string _name, int _count, Form _form, int _year1, int _year2, int _year3, int _year4)
        {
            this.name = _name;
            this.count = _count;
            this.form = _form;
            this.year1 = _year1;
            this.year2 = _year2;
            this.year3 = _year3;
            this.year4 = _year4;

        }
        public override string ToString()
        {
            return $"{name} {count} {form} {year1} {year2} {year3} {year4}";
        }

        public (int, int) MinMaxMoney()
        {
            List<int> money = new List<int>();
            money.Add(year1);
            money.Add(year2);
            money.Add(year3);
            money.Add(year4);
            int min = money.Min();
            int max = money.Max();
            var result = (min, max);
            return result;
        }


        float IManage.MaxAvg()
        {
            float sum = 0;
            float result;
            sum = (float)(year1 + year2 + year3 + year4);
            result = sum / 4;

            return result;
        }
        
        public static Company operator ++(Company obj)
        {
            obj.count++;
            return obj;
        }

        public static Company operator --(Company obj)
        {
            try
            {
                if (obj.count ==0)
                    throw new ZiroException("Null");
            }
            catch(ZiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            obj.count--;
            return obj;
        }

        public static Company operator + (Company obj, int i)
        {
            obj.count = obj.count + i;
            return obj;
        }
    }

    public static class Extension
    {
        public static Company DeleteInfo(Company company)
        {
            company.year1 = 0;
            company.year2 = 0;
            company.year3 = 0;
            company.year4 = 0;

            return company;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("EPAM", 450, Form.your, 45, 57, 38, 39);
            Console.WriteLine(company.MinMaxMoney());
            Console.WriteLine(((IManage)company).MaxAvg());
            Console.WriteLine(company.ToString());
            company++;
            Console.WriteLine(company.ToString());
            company--;
            Extension.DeleteInfo(company);
            Console.WriteLine(company.ToString());
        }
    }
}
