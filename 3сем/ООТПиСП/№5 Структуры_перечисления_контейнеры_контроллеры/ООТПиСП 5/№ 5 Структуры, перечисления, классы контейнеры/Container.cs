using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ООТПиСП5;

namespace ООТПиСП5
{
    public class Controller
    {
        int DocAmount;
        public Controller()
        {
            DocAmount = 0;
        }
        StructDocuments[] documents = new StructDocuments[100];
        public void CreadDocument()
        {
            DocAmount++;
            documents[DocAmount] = new StructDocuments();
        }
        public void AddProd()
        {
            Console.WriteLine("Введите номер документа");
            int number = int.Parse(Console.ReadLine());
            if (number > DocAmount || number < 0)
            {
                Console.WriteLine("Error number");
                return;
            }
            documents[number].AddProduct();
        }
        public void FindProd()
        {
            Console.WriteLine("Введите номер документа");
            int number = int.Parse(Console.ReadLine());
            documents[number].FoundProduct();
        }
        public void ReadFile()
        {
            StreamReader sr = new StreamReader("C:\\MyFile\\Универ\\3 сем\\ООТПиСП\\№5 Структуры_перечисления_контейнеры_контроллеры\\ООТПиСП 5\\№ 5 Структуры, перечисления, классы контейнеры\\Sample.txt");
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                //DocAmount++;
                //documents[DocAmount] = new StructDocuments();
                //AddProd();
                Console.WriteLine(line);
            }
            sr.Close();
        }
        public void Menu()
        {
            Console.WriteLine(
                "Menu\n" +
                "1)CreadDocument\n" +
                "2)AddProd\n" +
                "3)FindProd\n" +
                "4)ReadFile\n");
        }
    }
}
