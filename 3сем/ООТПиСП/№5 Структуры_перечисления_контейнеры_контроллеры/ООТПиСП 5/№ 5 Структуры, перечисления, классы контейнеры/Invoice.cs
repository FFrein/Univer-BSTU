using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//накладная
namespace ООТПиСП5
{
    internal partial class Invoice : Document
    {
        public string? ProductName { get; set; }
        public Invoice(string? PD = "Null")
        {
            ProductName = PD;
        }
        public override string ToString()
        {
            return $"Object type: {typeof(Invoice)}\n ProductName: {ProductName}";
        }
    }
}
