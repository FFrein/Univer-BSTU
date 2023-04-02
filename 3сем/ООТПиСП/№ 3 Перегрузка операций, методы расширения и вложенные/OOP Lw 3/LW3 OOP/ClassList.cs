using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {
        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        // очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        // добвление в начало
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public static LinkedList<T> operator *(LinkedList<T> first, LinkedList<T> second)
        {
            foreach (var item in second)
            {
                first.Add(item);
            }

            return first;

        }

        public static bool operator !=(LinkedList<T> first, LinkedList<T> second)
        {
            int f_counter = 0, s_counter = 0;
            // содержит ли список элемент
            foreach (var item in first)
            {
                f_counter++;
            }
            foreach (var item in second)
            {
                s_counter++;
            }

            if (f_counter != s_counter) return false;
            else return true;

        }

        public static bool operator ==(LinkedList<T> first, LinkedList<T> second)
        {
            int f_counter = 0, s_counter = 0;
            // содержит ли список элемент
            foreach (var item in first)
            {
                f_counter++;
            }
            foreach (var item in second)
            {
                s_counter++;
            }

            if (f_counter != s_counter) return true;
            else return false;
        }
        public static LinkedList<T> operator +(LinkedList<T> first, T str)
        {
            first.AppendFirst(str);
            return first;
        }
        public static LinkedList<T> operator --(LinkedList<T> first)
        {
            first.head = first.head.Next;
            if (first.head == null)
                first.tail = null;
            first.count--;
            return first;
        }
    }
    public class StaticOperation{
        public static void CheckDuplicate(LinkedList<string> Lst)
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("Checks for duplicate items in the list");
            foreach (string item1 in Lst)
            {
                j = 0;
                i++;
                foreach (string item2 in Lst)
                {
                    j++;
                    if (item1 == item2 && i != j)
                    {
                        Console.WriteLine(i + " = " + j);
                    }
                }
            }
            Console.WriteLine("End");
        }
        //функция подсчета количества слов с заглавной буквы
        public static void UpperCaseCounter(LinkedList<string> Lst)
        {
            char[] UpperCaseLetters = {'A', 'B', 'C' , 'D' , 'E' , 'F' , 'G' ,
                                        'H','I','J','K','L','M','N','O','P','Q',
                                        'R','S','T','U','V','W', 'X', 'Y', 'Z'};
            int counter = 0;
            string buff;
            foreach (string item in Lst)
            {
                buff = item.ToString();
                foreach (char letter in UpperCaseLetters)
                {
                    if (item != null && letter == buff[0]) counter++;
                }
            }
            Console.WriteLine("Upper Case Letters: " + counter);
        }
    }
}