using System;
using System.Collections.Generic;
using System.Text;

namespace Innumerable_14_Такси_Мое_решение__
{
    class Park<T> where T : Taxi
    {
        List<T> Taxis = new List<T>();
        public void tAdd(T taxi)
        {
            Taxis.Add(taxi);
        }
        public void tRemove(T taxi)
        {
            Taxis.Remove(taxi);
        }
        public void tRemoveAll(T taxi)
        {
            Taxis.Clear();
        }
        public object Find(Predicate<T> predicate)
        {
            foreach (T item in Taxis)
            {
                if (predicate(item))
                {
                    return item.Number;
                }
            }
            return null;
        }
    }
}
