using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ООТПиСП_6
{
    internal class Person : Exception
    {
        int Age;
        int age 
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 0)
                    throw new PersonInputAgeError("Incorrect age");
                else
                    Age = value;
            }
        }
        string name { get; set; }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
    public class PersonInputAgeError : ApplicationException
    {
        public PersonInputAgeError() { }
        public PersonInputAgeError(string message) : base(message) { }
        public PersonInputAgeError(string message, Exception innerException) : base(message, innerException) { }
        protected PersonInputAgeError(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}


