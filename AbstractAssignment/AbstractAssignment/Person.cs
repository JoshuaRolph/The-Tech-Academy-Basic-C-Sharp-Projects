using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; } 

        public virtual string SayName()
        {
        Console.WriteLine("Name:{0} {1}", firstName, lastName);
            return "Name unrecognised.";
        }
    }
}
