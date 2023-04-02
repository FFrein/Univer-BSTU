using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __2_Windows_Forms.Элементы_управления
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    internal class Adress
    {
        public string City { get; set; }
        public int index { get; set; }
        public string street { get; set; }
        public int house_num { get; set; }
        public int flat_num { get; set; }
        public Adress()
        {
            City = "City";
            index = 0;
            street = "street";
            house_num= 0;
            flat_num = 0;
        }
    }
    internal class Work
    {
        public string Company { get; set; }
        public string Post { get; set; }
        public int Experience { get; set; }
        public Work()
        {
            Company = "Company";
            Post = "Post";
            Experience = 0;
        }
    }
    internal class Student
    {
        public string FIO { get; set; }
        public int age { get; set; }
        public string special { get; set; }
        public string birthday { get; set; }
        public int course { get; set; }
        public int gropu { get; set; }
        public int avg_mark { get; set; }
        public string gender { get; set; }
        public Adress adress { get; set; }
        public Work work { get; set; }
        public Student() {
            FIO = "FIO";
            age = 0;
            special = "special";
            birthday = "birthday";
            gropu = 0;
            avg_mark = 0;
            gender = "gender";
            adress = new Adress();
            work = new Work();
        }
        public Student(string _fio, int _age, string _spec, string _birthday,int _course, int _group, int _avg_mark, string _gender, Adress _adress, Work _work)
        {
            FIO = _fio;
            age = _age;
            special = _spec;
            birthday = _birthday;
            course = _course;
            gropu = _group;
            avg_mark = _avg_mark;
            gender = _gender;
            adress = _adress;
            work = _work;
        }
    }
    
}

/*
 1. Какое основное назначение технологии Windows Forms, ее особенности, 
преимущества и недостатки? 

2. Зачем используется класс Form? Назовите основные методы, свойства и 
события данного класса. 
Свойства : это кнопки, поля и.д.


3. Поясните структуру проекта и назначение всех файлов? 

4. Зачем нужен атрибут STAThreadAttribute? 

5. Как в вашем проекте используются события и делегаты?

6. Объясните схему работы цепочек делегатов. 

7. Объясните механизм подписки и отмены подписки на события. 

8. Как создать вторую форму и передать туда данные? Есть ли другие 
способы?

9. Как во время выполнения приложения добавить/удалить элемент 
управления? 
*/