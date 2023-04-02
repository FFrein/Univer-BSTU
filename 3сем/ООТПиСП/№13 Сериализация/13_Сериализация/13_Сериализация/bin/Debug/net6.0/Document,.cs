using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООТПиСП_ЛР4
{
    internal abstract class Document : Interface
    {
        Date? date;
        Organization? OrgName;
        int year;
        int month;
        int day;
        int hour;
        int min;
        string ON;

        public string? DocumentName;
        public string Mymethod(string parm) 
        {
            return "";
        }
        public void InputDocumentName()
        {
            Console.Write("Введите название документа: ");
            DocumentName = Console.ReadLine();
        }
        public void IDocumentName() => InputDocumentName();
        public  void InputDate(int day, int month, int year, int? hour = null, int? min = null)
        {
            date = new Date(year, month, day, hour, min);
        }
        public void InputOrganization(string ON)
        {
            OrgName = new Organization(ON);
        }
        public virtual string ToString(string obj)
        {
            if(OrgName == null || date == null)
                return $"{obj}\n";
            else
            return $"{obj}\n OrganizationName: {OrgName.ToString()}\n date: {date.ToString()}\n";
        }
    }
}
