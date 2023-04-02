using System;
using System.Reflection.Metadata;
using System.Runtime;
//Документ, Квитанция, Накладная, Чек
//Накладная, Организация, Дата
//Чек, Организация, Дата
//Квитанция, Организация, Дата
namespace ООТПиСП_ЛР4
{
    public class Home
    {
        static void Main() {
            Ticket MyTicket = new Ticket(2);
            MyTicket.InputDocumentName();
            MyTicket.InputDate(21,03,2003,16,40);
            MyTicket.InputOrganization("ОАО");
            Console.WriteLine(MyTicket.ToString(MyTicket.ToString()));

            Receipt MyReceipt = new Receipt(144);
            MyReceipt.InputOrganization("АОА");
            Console.WriteLine(MyReceipt.ToString(MyReceipt.ToString()));

            Invoice MyInvoice = new Invoice("CoCaino");
            MyInvoice.InputDate(21, 03, 2003);
            MyInvoice.InputOrganization("ЪЫЪ");
            Console.WriteLine(MyInvoice.ToString());

            Interface obj = MyTicket as Document;

            //ссылка на интерфейс
            //Используем ссылку на объект MyTicket
            obj.IDocumentName();
            Console.WriteLine((MyTicket is Interface));

            //7
            Printer print = new Printer();
            print.IAmPrinting(MyTicket);
        }
    }
}
