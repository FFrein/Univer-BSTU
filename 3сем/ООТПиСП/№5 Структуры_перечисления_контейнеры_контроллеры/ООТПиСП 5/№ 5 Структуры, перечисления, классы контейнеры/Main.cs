using System;
using System.Reflection.Metadata;
using System.Runtime;

namespace ООТПиСП5
{
    public class Home
    {
        static void Main() {
            Controller Bughalteria = new Controller();
            do
            {
                Bughalteria.Menu();
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Bughalteria.CreadDocument();
                        break;

                    case 2:
                        Bughalteria.AddProd();
                        break;

                    case 3:
                        Bughalteria.FindProd();
                        break;

                    case 4:
                        Bughalteria.ReadFile();
                        break;
                    default:
                        return;
                }
            }while (true);
        }
    }
}
//что такое одноимённый метод блэт

//Иерархия
//Документ: Квитанция, Накладная, Чек
//Накладная: Организация, Дата
//Чек: Организация, Дата
//Квитанция: Организация, Дата

/*
 Собрать Бухгалтерию.
Найти суммарную стоимость продукции заданного 
наименования по всем накладным, количество чеков. 
Вывести две документы за указанный период времени
 */