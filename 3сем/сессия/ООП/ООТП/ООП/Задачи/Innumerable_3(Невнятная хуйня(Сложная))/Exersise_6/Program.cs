using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company();
            Form form1;
            form1 = Form.my;
            company1.Formm = form1;
            company1.Name = "Pizdec";
            company1.WorkerCount = 320;
            company1.Year1 = 15724;
            company1.Year2 = 16000;
            company1.Year3 = 1000;
            company1.Year4 = 724;

            Company company2 = new Company();
            Form form2;
            form2 = Form.our;
            company2.Formm = form2;
            company2.Name = "Pizda";
            company2.WorkerCount = 1000;
            company2.Year1 = 25724;
            company2.Year2 = 16000;
            company2.Year3 = 1000;
            company2.Year4 = 7240;

            Console.WriteLine(company1.MaxMin());
            Console.WriteLine(((IManage)company1).MaxAvg());
            company1++;
            Console.WriteLine(company1.WorkerCount);
            company1--;
            Console.WriteLine(company1.WorkerCount);
            Console.WriteLine((company1 + 2).WorkerCount);
            //company1.DeleteInfo();
            Console.WriteLine($"{company1.Year1}, {company1.Year2}, {company1.Year3}, {company1.Year4}");



            List<Company> companies = new List<Company>();
            companies.Add(company1);
            companies.Add(company2);

            Console.WriteLine(companies.GetMax());
            Console.ReadKey();
            IEnumerable<Company> SortByFormul()
            {
                var request = from item in companies
                              where companies.GetMax() != (null,null) && item.Formm == Form.my
                              select item;

                return request;
            }

            Console.WriteLine(SortByFormul());

        }
    }
}
