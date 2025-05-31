using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        Employee Employee = new Employee();
        // Properties to hold the first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize the full name
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Void method to print the full name in the specified format
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

