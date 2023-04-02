using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace КР_Шарпы
{
    internal class SuperQueue<T> where T : new()
    {
        public Queue<T> q;
        public void Add(T value)
        {
            q.Enqueue(value);
        }
        public void Delet(int number)
        {

            try
            {
                if (number == 5)
                {
                    throw new Exception("Нельзя удалить 5 элемент\n");
                }
                Queue<T> buff = new Queue<T>();
                int size = q.Count;
                for (int counter = 0; counter < size; counter++)
                {
                    if(counter != number - 1)
                       buff.Enqueue(q.Dequeue());
                }
                q = buff;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Show()
        {
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class News
    {
        public delegate void AccountHandler(string str);
        public event AccountHandler? Notify;
        public string ChannelName;

        public News(string name)
        {
            ChannelName = name;
        }

        public void CreatreNews(Reader rd)
        {
            Console.WriteLine($"{ChannelName} ТВ выпустила воности");
            Notify?.Invoke(rd.Read());
        }
    }
    public class Reader
    {
        public string name;

        public Reader(string _name)
        {
            name = _name;
        }
        public string Read()
        {
            return $"{name} читает новости";
        }
    }


    public static class Prog
    {
        public static void Main()
        {
            //1
            SuperQueue<int> queue = new SuperQueue<int>();
            queue.q = new Queue<int>();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);
            queue.Add(6);

            queue.Delet(3);

            queue.Show();
            //2


            Console.WriteLine("\n\nTask2");

            int[] mass = { 1, -2, 3, 4, 5, 0, -1, 2, -3 };

            var selected = mass.Where(p => p >= 0);
            
            foreach(var item in selected)
                Console.WriteLine(item);
            //3
            Console.WriteLine("\n\nTask3");

            News BelNews = new News("Говно ТВ");
            News BelNews2 = new News("Понос ТВ");

            Reader NP = new Reader("NP");
            Reader NK = new Reader("NK");

            BelNews.Notify += (string str) => Console.WriteLine(NP.Read());
            BelNews.Notify += (string str) => Console.WriteLine(NK.Read());

            BelNews2.Notify += (string str) => Console.WriteLine(NK.Read());

            BelNews.CreatreNews(NP);
            BelNews2.CreatreNews(NP);
        }
    }
}


















class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler? Notify;              // 1.Определение события
    public Account(int sum) => Sum = sum;
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
        }
        else
        {
            Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
        }
    }
}