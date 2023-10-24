using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Professor : Person
    {
        public string Subject {  get; set; }
        public Professor(string FirstName, string LastName, int Age, string Subject)
            : base(FirstName, LastName, Age)
        {
            this.Subject = Subject;
        }

        public void Explain() => Console.WriteLine("I'm explaining");
    }
}
