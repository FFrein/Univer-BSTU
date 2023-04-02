using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_18_Порождающие_паттерны_проектирования
{
    class Singleton
    {
        private static Singleton instance;
        public string BG_Color { get; private set; }
        public string Size { get; private set; }
        public string Font { get; private set; }

        private Singleton(string cl, string sz, string ft)
        { 
            this.BG_Color = cl;
            this.Size = sz;
            this.Font = ft;
        }

        public static Singleton getInstance(string cl, string sz, string ft)
        {
            if (instance == null)
                instance = new Singleton(cl, sz, ft);
            return instance;
        }
    }
}
