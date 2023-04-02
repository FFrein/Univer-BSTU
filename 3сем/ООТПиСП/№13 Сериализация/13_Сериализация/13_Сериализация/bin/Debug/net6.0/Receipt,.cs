using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//квитанция

namespace ООТПиСП_ЛР4
{
    internal class Receipt : Document
    {
        int ProductPrice { get; set; }
        public Receipt(int PP)
        {
            ProductPrice = PP;
        }

        public override string ToString()
        {
            return $"Object type: {typeof(Receipt)}\n ProductPrice: {ProductPrice}";
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj);
        }
        //public override static bool ReferenceEquals(object? objA, object? objB)
        //protected override object MemberwiseClone()
        //public override Type GetType(Type obj)

    }
}
