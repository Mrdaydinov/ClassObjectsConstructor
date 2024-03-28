using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsConstructor
{
    internal class Person
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public bool IsAdult { get; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            
            if (Age > 18)
                IsAdult = true;
            else
                IsAdult = false;
        }
    }
}
