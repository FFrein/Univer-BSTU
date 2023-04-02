using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practice_Exam_2_Repited
{
   [Serializable]
     public class User : IComparable
    {
        private string email;
        private int password;
        public string status;
        public string Status
        {
            set
            {
                if(value == "signin" || value == "signout")
                {
                    status = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return status;
            }
        }


        public User(string email, int password, string status)
        {
            this.email = email;
            this.password = password;
            this.status = status;
        }

        public int CompareTo(object o)
        {
            User a = o as User;
            if(a.password > this.password)
            {
                return 1;
            }
            else if(a.password < this.password)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return ("МЭЙЛ " + email + " ПАРОЛЬ " + password + " СТАТУС " + status);
        }

        public override int GetHashCode()
        {
            return (password - 235);
        }

        public override bool Equals(object obj)
        {
            User user1 = obj as User;
            if (user1 != null)
            {
                if (user1.email == this.email)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
      
    }

    [Serializable]
    public class WedLet<T>
    {
        public static LinkedList<T> listic = new LinkedList<T>();
        public void Add(T obj)
        {
            listic.AddLast(obj);
        }
        public void Remove(T obj)
        {
            listic.Remove(obj);
        }
        public int Count()
        {
            return listic.Count();
        }

    }





    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                User user1 = new User("qwert", 1111, "signout");
                User user2 = new User("asdfg", 2222, "signin");
                User user3 = new User("zxcbv", 3333, "signout");
                User user4 = new User("asdghkj234", 4444, "signin");
                User user5 = new User("asd123", 5555, "signin");
                Console.WriteLine(user2.ToString());
                Console.WriteLine(user1.ToString());
                Console.WriteLine(user3.ToString());
                Console.WriteLine(user4.ToString());
                Console.WriteLine(user5.ToString());
                Console.WriteLine(user5.CompareTo(user1));
                WedLet<User> github = new WedLet<User>();
                github.Add(user1);
                github.Add(user2);
                github.Add(user3);
                github.Add(user4);
                github.Add(user5);

                var linq1 = from s in WedLet<User>.listic
                            where s.status == "signin"
                            select s;
                Console.WriteLine(linq1.Count());


                var serialize = new BinaryFormatter();
                using (var file = new FileStream("file.bin", FileMode.OpenOrCreate))
                {
                    serialize.Serialize(file, github);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            



        }
    }
}
