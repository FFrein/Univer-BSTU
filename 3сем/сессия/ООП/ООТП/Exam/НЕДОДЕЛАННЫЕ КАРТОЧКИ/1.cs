using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Создать класс StudentCard с приватными полями balance и ExDate - пользовательский тип данных(класс) со свойствами number,
// mounth, year( 2 последние цифры ), и status ( со значениями locked и unlicked) реализовать с помощью перечисления.
// Создать класс IPay с методом int Pay(int sum). Явно реализовать в классе. пердусмотреть когда sum не больше 100, а balance 
// не должен быть отрицательным, и это записать в файл. 


namespace Practice_Exam_11
{
    public enum Status { locked, unloced};

    //public interface IPay
    //{
    //    int Pay();
    //}

    public class ExDate
    {
        public int number;
        public int Number
        {
            set
            {
                if(number<0 || number > 31)
                {
                    throw new Error();
                    
                    
                }
                else
                {
                    number = value;
                }
            }
            get
            {
                return number;
            }
        }
        public int mounth;
        public int Mounth
        {
            set
            {
                if(mounth<0 || mounth > 12)
                {
                    throw new Error2();
                }
                else
                {
                    mounth = value;  
                }
            }
            get
            {
                return mounth;
            }
        }

        public int year;
        public int Year
        {
            set
            {
                if(year>100 || year < 0)
                {
                    throw new Error3();
                    
                }
                else
                {
                    year = value;
                }
            }
            get
            {
                return year;
            }
        }
        public ExDate(int number, int mounth, int year)
        {
            this.number = number;
            this.mounth = mounth;
            this.year = year;
        }

    }
    public class StudentCard
    {
        public int balance;
        
        public int Balance
        {
            set
            {
                if(balance>100 || balance < 0)
                {
                    throw new Error();
                    
                }
                else
                {
                    balance = value;
                }
            }
            get
            {
                return balance;
            }
        }
            

            
        public ExDate date;
        public Status st;
        
        public StudentCard(int balance, ExDate date, Status st)
        {
            this.balance = balance;
            this.date = date;
            this.st = st;
        }

        public override string ToString()
        {
            return ("BALANS " + balance + " STATUS " +st);
        }

        //int IPay.Pay(int sum, StudentCard obj)
        //{
        //    StudentCard card = obj as StudentCard;
        //    sum = this.balance + card.balance;
        //    return sum;
        //}
    }
    class Error : Exception
    {
        public Error() : base("ERROR ------------ 1") { }

    }
    class Error2 : Exception
    {
        public Error2() : base("ERROR ----------- 2") { }

    }
    class Error3 : Exception
    {
        public Error3() : base("ERROR ------------ 3") { }

    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {


                ExDate date1 = new ExDate(30, 11, 20);
                ExDate date2 = new ExDate(18, 6, 34);
                ExDate date3 = new ExDate(10, 10, 10);
                ExDate date4 = new ExDate(1, 1, 2);
                StudentCard stcard1 = new StudentCard(3, date1, Status.locked);
                StudentCard stcard2 = new StudentCard(1000, date2, Status.unloced);
                StudentCard stcard3 = new StudentCard(48, date3, Status.unloced);
                StudentCard stcard4 = new StudentCard(10, date4, Status.locked);
                Console.WriteLine(stcard1.ToString());
                Console.WriteLine(stcard2.ToString());
                Console.WriteLine(stcard3.ToString());
                Console.WriteLine(stcard4.ToString());
            }
            catch (Error err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Error2 err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Error3 err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}
