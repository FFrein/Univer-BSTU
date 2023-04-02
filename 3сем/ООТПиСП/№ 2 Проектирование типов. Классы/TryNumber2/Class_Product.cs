using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryNumber2
{
    partial class Product
    {
        const string type = "Product";
        public int products = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public int UPC { get; set; }
        public string producer { get; set; }
        public int price { get; set; }
        public int shell_time { get; set; }
        public int amount { get; set; }



        public Product(ref int Hash_number)
        {

        }
        static Product()
        {

        }
        private Product()
        {
            products++;
        }

    }
}
/*
 Создать класс Product: id, Наименование, UPC, 
Производитель, Цена, Срок хранения, Количество.
Свойства и конструкторы должны обеспечивать проверку 
корректности. Добавить метод вывода общей суммы 
продукта.
Создать массив объектов. Вывести:
a) список товаров для заданного наименования;
b) список товаров для заданного наименования, цена которых 
не превосходит заданную;
 */