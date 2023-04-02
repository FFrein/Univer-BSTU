using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПиСП5
{
    struct Products : ICloneable , IComparable
    {
        int nub = 15;
        Invoice invoice;
        Receipt receipt;
        Ticket ticket;

        public Products()
        {
            invoice = new Invoice();
            receipt = new Receipt();
            ticket = new Ticket();
        }
        public Products(string? str, int? price, int? amount)
        {
            invoice = new Invoice(str);
            receipt = new Receipt(price);
            ticket = new Ticket(amount);
        }
        public void InputInvoice(string str)
        {
            invoice = new Invoice(str);
        }

        public void InputeTicket(int? amount)
        {
            ticket = new Ticket(amount);
        }

        public void InputReceipt(int price)
        {
            receipt = new Receipt(price);
        }
        public string? FindName()
        {
            return invoice.ProductName;
        }
        public int? GetPrice()
        {
            return receipt.ProductPrice;
        }
        public object Clone()
        {
            return new Products(invoice.DocumentName, ticket.amount , receipt.ProductPrice);
        }
        public int CompareTo(object? obj)
        {
            if (obj is Products) return invoice.ProductName.CompareTo(invoice.ProductName);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
    //контейнер
    public class StructDocuments 
    {
        private Products[] Product;
        private int counter;
        private int? Products_Price;
        public StructDocuments()
        {
            counter = 0;
            Product = new Products[100];
            Products_Price = 0;
        }
        
        public void AddProduct()
        {
            Console.Write("Введите название продукта: ");
            InputProduct(Console.ReadLine());
            Console.Write("Введите количество продукта: ");
            InputeTicket(int.Parse(Console.ReadLine()));
            Console.Write("Введите цену за одну штуку продукта: ");
            InputReceipt(int.Parse(Console.ReadLine()));
        }
        public void FoundProduct()
        {
            Console.Write("Введите название разыскиваемого продукта: ");
            string FoundName = Console.ReadLine();
            int Ticket_amount = 0;
            for (int i = 0; i <= counter; i++)
            {
                if (Product[i].FindName() == FoundName)
                {
                    Products_Price += Product[i].GetPrice();
                    Ticket_amount++;
                }
            }
            Console.WriteLine("    Общая стоимость: " + Products_Price
                + "\n    Кол чеков: " + Ticket_amount);
        }

        private void InputeTicket(int? amount)
        {
            Product[counter].InputeTicket(amount);
        }
        private void InputProduct(string? str)
        {
            Product[counter].InputInvoice(str);
        }
        private void InputReceipt(int price)
        {
            Product[counter].InputReceipt(price);
        }
    }
    enum Data
    {
        Company,
        Product,
        Price,
        Amount
    }
}
