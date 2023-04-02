using System;
using System.Collections.Generic;

namespace Innumerable_13_Пользователь_Мое_решение__
{
    class Podliva
    {

        static void Main(string[] args)
        {
            try
            {

                User user1 = new User("flex", "1242vv323");
                User user2 = new User("Podliva", "qweqweqw");
                User user3 = new User("vlad", "123asdsa2");
                User user4 = new User("help", "111d3123");

                

                List<User> users = new List<User>(4);
                users.Add(user1);
                users.Add(user2);
                users.Add(user3);
                users.Add(user4);

                // linq не выходит

                Console.WriteLine(user1.ToString());
                Console.WriteLine(user2.ToString());
                Console.WriteLine(user3.ToString());
                Console.WriteLine(user4.ToString());
            }
            catch( Exception1 e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception2 e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
