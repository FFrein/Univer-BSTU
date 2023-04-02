using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2_6
{
    [Serializable]
    public class User : IComparable<User>
    {
        public User() { }
        public User(string em, string pass)
        {
            email = em;
            password = pass;
            Status = StatusList.signout;
        }
        private string email;
        private string password;
        public enum StatusList
        {
            signin,
            signout
        }
        public StatusList Status { get; set; }

        public override bool Equals(object? obj)
        {
            return true;
        }
        public new Type GetType()
        {
            return typeof(User);
        }
        public override int GetHashCode()
        {
            return 123;
        }
        public override string ToString()
        {
            return email;
        }
        public int CompareTo(User? obj)
        {
            if (obj.email.Length == null || email.Length == null)
            {
                Console.WriteLine("email не определён");
            }
            if (email.Length == obj.email.Length)
                return 0;
            if(email.Length > obj.email.Length)
                return 1;
            if (email.Length < obj.email.Length)
                return -1;
            throw new Exception("Ошибка в методе CompareTO");
        }
    }
    
    public class WebNet
    {
        public LinkedList<User> UserList = new LinkedList<User>();
        public void AddUser(User usr)
        {
            usr.Status = User.StatusList.signin;
            UserList.AddLast(usr);
        }
        public void DeletUser(User usr)
        {
            UserList.Remove(usr);
        }
    }

    public class Prog
    {
        public static void Main()
        {
            User user1 = new User("123", "123");
            User user2 = new User("login","password");
            User user3 = new User("admin","admin");
            User user4 = new User("User","qwerty");
            User user5 = new User("Anton", "SlozhniParol");

            Console.WriteLine(
                user1.CompareTo(user2) + " " +
                user5.CompareTo(user3) + " " +
                user4.CompareTo(user1) + " " +
                user1.CompareTo(user5)
                );

            WebNet github = new WebNet();
            github.AddUser(user1);
            github.AddUser(user2);
            github.AddUser(user3);
            github.AddUser(user4);
            github.AddUser(user5);

            github.DeletUser(user3);

            foreach (var p in github.UserList)
                Console.WriteLine(p);



            var elems = from p in github.UserList
                        where p.Status == User.StatusList.signin
                        select p;
            foreach (var prop in elems)
                Console.WriteLine(prop);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));

            using (FileStream fs = new FileStream("User.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, user1);

                Console.WriteLine("Object has been serialized");
            }
        }
    }
}
