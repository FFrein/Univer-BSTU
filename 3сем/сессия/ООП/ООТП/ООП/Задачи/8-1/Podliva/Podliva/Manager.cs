using System;
using System.Collections.Generic;
using System.Text;

namespace Podliva
{
    class Manager
    {
        public delegate void Sale();
        public event Sale sales;
        public void SaleOn()
        {
            sales();
        }
    }
}
