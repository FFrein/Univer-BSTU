using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7_Обобщения
{
    internal class Document<T> : Interface<T> where T : Date<string>
    {
        int year;
        int month;
        int day;
        int hour;
        int min;
        string ON;
        public T OrgName;
        public T DocumentName;

        public Document(T docname)
        {
            DocumentName = docname;
        }
        public Document()
        {

        }
        public T Add
        {
            set{
                InputOrganization(value);
            }
        }
        public T Delete
        {
            set
            {
                
            }
        }
        public T Watch
        {
            get
            {
                return OrgName;
            }
        }
        private void InputOrganization(T ON)
        {
            OrgName = ON;
        }
        public  void InputDate(int d, int m, int y, int h, int mi)
        {
            year = y;
            month = m;
            day = d;
            hour = h;
            min = mi;
        }

        public T String()
        {
            return DocumentName;
        }
    }
}
