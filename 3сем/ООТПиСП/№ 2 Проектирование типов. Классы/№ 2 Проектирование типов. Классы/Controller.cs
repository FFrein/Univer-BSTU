//Вариант 10
namespace tovarka 
{
    static class House
    {
        static int Main()
        {
            bool end = false;
            int choice;
            int mass_elem;
            int mass_lenght = 1;
            string? findName;
            int? findPrice;
            int NumberForID = 12;
            int? takecol;
            tovarka.Product[] ProductMassive = new tovarka.Product[100];

          /*  
            tovarka.Product obj = new tovarka.Product(ref NumberForID, out takecol);
            for (int i = 0; i < 10; i++)
            {
                obj[i] = (float)1.5 * i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", obj[i]);
            }
          пример как работает индексатор
          */
            do
            {
                Console.WriteLine("Главное меню\n" +
                    "1)Доавить продукт\n" +
                    "2)Посмотреть информацию о продукте\n" +
                    "3)Посмотреть общую сумму продукта\n" +
                    "4)Cписок товаров для заданного наименования\n" +
                    "5)Список товаров для заданного наименования, цена которых не превосходит заданную\n" +
                    "6)Информация о классе\n"
                    );
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ProductMassive[mass_lenght] = new tovarka.Product(ref NumberForID, out takecol);
                        ProductMassive[mass_lenght].Interface();
                        mass_lenght++;
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Введите номер продукта в массиве");
                        mass_elem = Convert.ToInt32(Console.ReadLine());
                        if (mass_lenght > mass_elem)
                        {
                            ProductMassive[mass_elem].TotalAmountProduct();
                        }
                        else
                            Console.WriteLine("Error\n");
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Введите номер продукта в массиве");
                        mass_elem = Convert.ToInt32(Console.ReadLine());
                        if (mass_lenght > mass_elem)
                        {
                            ProductMassive[mass_elem].ShowInfo();
                        }
                        else
                            Console.WriteLine("Error\n");
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        findName = Console.ReadLine();
                        for (int i = 1; i < mass_lenght; i++)
                        {
                            if (findName == ProductMassive[i].Name)
                                Console.WriteLine("Товар с номером: " + i);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        findPrice = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < mass_lenght; i++)
                        {
                            if (findPrice >= ProductMassive[i].Price)
                                Console.WriteLine("Товар с номером: " + i);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        if (mass_lenght != 0)
                            tovarka.Product.ClassInfo();
                        Console.WriteLine("\n");
                        break;
                    default:
                        break;
                }
            } while (!end);
            return 0;
        }
    }
}
