using System;
using System.Collections.Generic;
using System.Text;

namespace Innumerable_13_Пользователь_Мое_решение__
{
    class Exception1 : Exception
    {
        public Exception1() : base("Пароль слишком короткий или слишком длинный") { }
       
    }
    class Exception2 : Exception
    {
        public Exception2() : base("Пароль не может состоять только из цифр") { }

    }
}
