using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string FirstName, string LastName) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public Person(string FirstName, string LastName, int Age) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public void Greet() => Console.WriteLine($"Hi i'm {FirstName} {LastName}\nAge {Age}");
    }
}
