using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innumerable_10_БГТУ_Мое_решение__
{
    public interface IClearnable
    {
        void lClearn();
    }
    class Groups : IClearnable
    {
        public  List<BSTUStudent> Array = new List<BSTUStudent>();
        public List<BSTUStudent> GetArray { get { return Array; } }
        public void lAdd(BSTUStudent obj)
        {
            Array.Add(obj);
        }
        public void lClearn()
        {
            Array.Clear();
        }
    }
}
