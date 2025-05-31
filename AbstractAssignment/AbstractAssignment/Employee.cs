using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public override string SayName()
        {
            Console.WriteLine("Employee:" + firstName + " " + lastName);
            return SayName();
        }
    }
}
