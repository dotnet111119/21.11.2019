using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2111
{
    public class Person : Human
    {
        public string _name;
        public int _age;
        public string _address;

        // Ctor overloading
        // 1
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(string name, int age, string address) : this(name, age)
        {
            //_name = name;
            //_age = age;
            _address = address;
        }


        // 2
        //public Person(string name, int age, string address = "unknown")
        //{
        //_name = name;
        //_age = age;
        //_address = address;
        //}

    }
}
