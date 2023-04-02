namespace LW10
{
    class Home
    {
        public static void Main()
        {
            //Quest 1
            string[] Month = { "June", "July", "August", "September", "October", "November", "December", "January", "February", "March", "April", "May" };

            // Использование точечной нотации
            IEnumerable<string> sequenceType1 = Month
            .Where(n => n.Length >= 4)
            .Select(n => n);

            foreach (string name in sequenceType1)
                Console.WriteLine("{0}", name);

            Console.WriteLine();

            // Использование синтаксиса выражения запроса
            IEnumerable<string> sequenceType2 = from n in Month
                                           where n.Length >= 4
                                           select n;
            
            foreach (string name in sequenceType2)
                Console.WriteLine("{0}", name);
            Console.WriteLine();

            //Quest 2 - 3
            List<Product> ListOne = new List<Product>();
            ListOne.Add(new Product(1, "CSGO", 100, 1, "Valve"));
            ListOne.Add(new Product(1, "Dota2", 0, 1, "Valve"));
            ListOne.Add(new Product(1, "Rust", 150, 1, "FacePunch"));
            ListOne.Add(new Product(1, "Cyber Punk 2077", 200, 1, "Cd Project Red"));
            ListOne.Add(new Product(1, "Project Zomboid", 100, 4, "Hz"));
            ListOne.Add(new Product(1, "Don't starve together", 10, 4, "Hz2"));
            ListOne.Add(new Product(1, "The Long Dark", 70, 1, "Hz3"));
            ListOne.Add(new Product(1, "PUBG", 100, 1, "BattlStateGame"));
            ListOne.Add(new Product(1, "ARK", 30, 2, "Debili"));
            ListOne.Add(new Product(1, "Dark Souls 3", 170, 1, "Genius"));

            //список товаров для заданного наименования;
            IEnumerable<Product> FindCompany = from n in ListOne
                                                where n.Producer == "Valve"
                                                select n;

            Console.WriteLine("FindCompany");
            foreach (var obj in FindCompany)
                Console.WriteLine(obj.Name + "\t" + obj.Producer);
            Console.WriteLine();

            //список товаров для заданного наименования, цена которых не 
            //превосходит заданную;
            IEnumerable<Product> FindPrice = from n in ListOne
                                             where n.Price <= 100
                                             select n;

            Console.WriteLine("FindPrice");
            foreach (var obj in FindPrice)
                Console.WriteLine(obj.Name + "\t" + obj.Price);
            Console.WriteLine();

            //количество наименований цена которых больше 100
            IEnumerable<Product> FindPriceLimit = from n in ListOne
                                             where n.Price >= 100
                                             select n;
            Console.WriteLine("FindPriceLimit");
            foreach (var obj in FindPriceLimit)
                Console.WriteLine(obj.Name + "\t" + obj.Price);
            Console.WriteLine();

            //максимальный товар (ваш критерий максимальности)
            IEnumerable<Product> MaxProduct = from n in ListOne
                                              orderby n.Price 
                                              select n;

            Console.WriteLine("MaxProductPrice");
            int max = 0;
            foreach (var obj in MaxProduct)
                if (max < obj.Price)
                    max = obj.Price;

            Console.WriteLine(max + "\n");

            //упорядоченный набор товаров по производителю, а потом по 
            //количеству
            IEnumerable<Product> SortedByProducer = from n in ListOne
                                                    orderby n.Producer
                                                    select n;
            Console.WriteLine("SortedByProducer");
            foreach (var obj in SortedByProducer)
                Console.WriteLine(obj.Name + "\t" + obj.Producer);
            Console.WriteLine();


            Console.WriteLine("SortedByAmount");
            IEnumerable<Product> SortedByAmount = from n in ListOne
                                                  orderby n.Amount
                                                  select n;

            foreach (var obj in SortedByAmount)
                Console.WriteLine(obj.Name + "\t" + obj.Amount);
            Console.WriteLine();

            //Quest 4
            IEnumerable<Product> CustomFiltered = from n in ListOne
                                                  where n.Producer.StartsWith("V")
                                                  where n.Name.Contains("D")
                                                  orderby n.Price
                                                  join c in FindPrice on n.Price equals c.Price
                                                  select n;
            Console.WriteLine("CustomFiltered");
            foreach (var obj in CustomFiltered)
                Console.WriteLine(obj.Name + "\t" + obj.Producer);
            Console.WriteLine();

            //Quest 5
            IEnumerable<Product> PartOne = from n in ListOne
                                           where n.Price >= 170
                                           select n;

            IEnumerable<Product> PartTwo = from n in ListOne
                                           where n.Price <= 170
                                           join c in PartOne on n.Price equals c.Price
                                           select n;

            Console.WriteLine("Join");
            foreach (var obj in PartTwo)
                Console.WriteLine(obj.Name + "\t" + obj.Price);
            Console.WriteLine();

        }
    }
}