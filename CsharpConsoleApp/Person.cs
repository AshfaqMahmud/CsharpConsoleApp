using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    internal class Person
    {
        // record implementation using class
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Person person)
            {
                return Name == person.Name && Age == person.Age;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        public static implicit operator Person(string name)
        {
            return new Person(name, 0);
        }
        public static explicit operator string(Person person)
        {
            return person.Name;
        }
        public static implicit operator int(Person person)
        {
            return person.Age;
        }
        
    }
}
