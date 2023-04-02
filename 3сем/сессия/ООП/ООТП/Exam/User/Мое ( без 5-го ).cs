using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Создать абстрактный класс AbstractUser с полем Data.Создать клас User с полями password и login, который является потомком обстрактного класа. 
//2-3. Создать исключения : 1)Если длинна пароля меньше 6 символов 2)если длинна пароля больше 12 символов 3) если пароль состоит из одних цифр.
//4. Создать 4 объекта типа user и поместить их в лист. Продемонстрировать работу исключений.
//5. На основе linq написать запрос : найти пользователя, добавленного раньше всех(по полю Data). Вроде как-то так.


namespace Practice_Exam_9
{
    class Program
    {
        abstract class AbstractUser
        {
            public DateTime Date;
        }

        class User : AbstractUser
        {
            public string password;
            public string login;

            public string Password
            {
                set
                {
                    if(value.Length < 6)
                    {
                        throw new Error1();
                    }
                    else if (value.Length > 12)
                    {
                        throw new Error2();
                    }
                    else
                    {
                        password = value;
                    }

                }
                get
                {
                    return password;
                }
            }

            public User(string login, string password, DateTime Date)
            {
                this.login = login;
                Password = password;
                this.Date = Date;
            }

            public override string ToString()
            {
                return (" LOGIN " + login + " PASSWORD " + password + " TIME " + Date);
            }

           
        }

        //class listic<User>
        //{
        //    List<User> list = new List<User>();

        //    public DateTime FindMin(User obj)
        //    {
        //        DateTime time1 = new DateTime();
        //        if (obj.Date < this.Date)
        //        {
        //            obj.Date = time1;
        //            return time1;
        //        }
        //        else
        //        {
        //            return obj.Date;
        //        }
        //    }
        //}

        class Error1 : Exception
        {
            public Error1() : base("ERROR ----- 2") { }
        }
        class Error2 : Exception
        {
            public Error2() : base("ERROR ----- 1") { }

        }

        static void Main(string[] args)
        {
            try
            {



                DateTime time1 = new DateTime(2001, 6, 27);
                DateTime time2 = new DateTime(2011, 4, 16);
                DateTime time3 = new DateTime(2020, 5, 15);
                DateTime time4 = new DateTime(2009, 7, 8);
                User user1 = new User("arsenii", "1242323", time1);
                User user2 = new User("dima", "qweqweqw", time2);
                User user3 = new User("dasha", "123asdsa2", time3);
                User user4 = new User("valera", "1113123", time4);
                Console.WriteLine(user1.ToString());
                Console.WriteLine(user2.ToString());
                Console.WriteLine(user3.ToString());
                Console.WriteLine(user4.ToString());

                List<User> listik = new List<User>();
                listik.Add(user1);
                listik.Add(user2);
                listik.Add(user3);
                listik.Add(user4);

                //var linq1 = from user in listik
                //            where user.FindMin(user)


            }
            catch(Error1 e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Error2 e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}
