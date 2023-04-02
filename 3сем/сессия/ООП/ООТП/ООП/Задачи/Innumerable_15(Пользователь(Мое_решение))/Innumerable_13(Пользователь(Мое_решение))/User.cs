using System;
using System.Collections.Generic;
using System.Text;

namespace Innumerable_13_Пользователь_Мое_решение__
{
    class User : AbstractUser
    {
        public override string ToString()
        {
            return (" LOGIN " + Login + " PASSWORD " + password );
        }
        public string Login { get; set; }
        private string password;
        public string lowList = "abcdefghijklmnoprstuvwxyz";
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 6 || value.Length > 12)
                {
                    throw new Exception1();
                }
                else
                {
                    if (value.IndexOfAny(lowList.ToCharArray()) == -1)
                    {
                        throw new Exception2();
                    }
                    else
                    {
                        password = value;
                    }
                }
            }
        }
        public User(string login, string password)
        {
            Password = password;
            Login = login;
        }

    }
}
