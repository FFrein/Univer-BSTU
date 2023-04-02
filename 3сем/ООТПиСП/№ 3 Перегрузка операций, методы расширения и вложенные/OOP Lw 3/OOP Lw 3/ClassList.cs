namespace LW3
{
    public class MyList
    {
        public String?[] Items;
        public MyList()
        {
            Items = new String[0];
        }
        public void ViewItems()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.Write(i + ")");
                Console.WriteLine(Items[i]);
            }
        }
        //функция ввода строки
        private void InputItem(int position)
        {
            Array.Resize(ref Items, Items.Length + 1);
            Items[position] = Convert.ToString(Console.ReadLine());
        }
        //функция добавление элемента в начало массива item+list
        //add to the top of the list
        public static MyList operator +(MyList List, String Item)
        {

            if (List.Items.Length == 0)
            {
                List.InputItem(0);
            }
            else
            {
                Array.Resize(ref List.Items, List.Items.Length + 1);
                for (int i = 0; i < List.Items.Length - 1; i++)
                {
                    List.Items[List.Items.Length - 1 - i] = List.Items[List.Items.Length - 2 - i];
                }
                List.Items[0] = Item;
            }
            return List;
        }
        //функция добавление элемента в конец массива 
        public void AddEnd()
        {
            InputItem(Items.Length);
        }
        //функция удаление элемента из начала массива --list
        public static MyList operator --(MyList List)
        {
            for (int i = 0; i < List.Items.Length - 1; i++)
            {
                List.Items[i] = List.Items[i + 1];
            }
            Array.Resize(ref List.Items, List.Items.Length - 1);
            return List;
        }
        //вложенный клас Product, который содержит Id, название организации.Проинициализируйте его
        public class Product
        {
            int? id = 0;
            public int? Id
            {
                get { return id; }
                set { id = value; }
            }
            string? organization = "";
            public string? Organization
            {
                get { return organization; }
                set { organization = value; }
            }
        }
        //вложенный класс Developer (разработчик – фио, id, отдел). Проинициализируйте
        public class Developer
        {
            int? id = 0;
            public int? Id
            {
                get { return id; }
                set { id = value; }
            }
            string? fio = "";
            public string? FIO
            {
                get { return fio; }
                set { fio = value; }
            }
            string? department = "";
            public string? Department
            {
                get { return department; }
                set { department = value; }
            }
        }

        //проверка на неравенство списков !=
        public static bool operator !=(MyList ListOne, MyList ListTwo)
        {
            if (ListOne.Items.Length != ListTwo.Items.Length)
                return true;
            return false;
        }
        public static bool operator ==(MyList ListOne, MyList ListTwo)
        {
            if (ListOne.Items.Length == ListTwo.Items.Length)
                return true;
            return false;
        }
        //объединение двух списков *
        public static MyList operator *(MyList ListOne, MyList ListTwo)
        {
            Array.Resize(ref ListOne.Items, ListOne.Items.Length + ListTwo.Items.Length);
            for (int i = 0; i < ListOne.Items.Length - 1; i++)
            {
                ListOne.Items[ListOne.Items.Length - ListTwo.Items.Length + i] = ListTwo.Items[i];
            }
            return ListOne;
        }
    }
    public static class StaticOperation
    {
        //функция проверки на повторяющиеся элементы в списке
        public static void CheckDuplicate(MyList List)
        {
            Console.WriteLine("Checks for duplicate items in the list");
            for (int i = 0; i < List.Items.Length; i++)
            {
                for (int j = 1 + i; j < List.Items.Length; j++)
                {
                    if (List.Items[i] == List.Items[j])
                    {
                        Console.WriteLine(i + " = " + j);
                    }
                }
            }
            Console.WriteLine("End");
        }
        //функция подсчета количества слов с заглавной буквы
        public static void UpperCaseCounter(MyList List)
        {
            char[] UpperCaseLetters = {'A', 'B', 'C' , 'D' ,
                                       'E' , 'F' , 'G' , 'H',
                                       'I','J','K','L','M','N',
                                       'O','P','Q','R','S','T',
                                       'U','V','W', 'X', 'Y', 'Z'};

            int counter = 0;
            foreach (string? item in List.Items)
            {
                foreach (char letter in UpperCaseLetters)
                {
                    if (item != null && letter == item[0]) counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}