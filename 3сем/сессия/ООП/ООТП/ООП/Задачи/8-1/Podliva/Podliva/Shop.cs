using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podliva
{
    class Shop : IEnumerable
    {
        public Queue<Item> queue = new Queue<Item>();
        public Queue<Shop> shop = new Queue<Shop>();

        public Queue<Item> GetQueue { get { return queue; } }

        public void qAdd(Item obj)
        {
            queue.Enqueue(obj);
        }
        public void qRemove(Item obj)
        {
            queue.Dequeue();
        }
        public void qClear(Item obj)
        {
            queue.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return queue.GetEnumerator();
        }
        public static int operator +(Shop obj)
        {
            obj.sAdd(obj);

            return 0;

        }
        public static int operator -(Shop obj)
        {
            obj.sRemove(obj);

            return 0;

        }
        public void sAdd(Shop obj)
        {
            shop.Enqueue(obj);
        }
        public void sRemove(Shop obj)
        {
            shop.Dequeue();
        }
    }
}
