using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person:IComparable<Person>
    {
        string _name;
        string _surname;
        int _age;
        public string Name { get { return _name; } set { _name = value;  } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { _age = value; } }

        public static bool operator <(Person person1, Person person2)
        {
            return person1.Age < person2.Age;
        }

        public static bool operator >(Person person1, Person person2)
        {
            return person1.Age > person2.Age;
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1 == person2;  
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return person1 != person2;
        }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }
    
}
