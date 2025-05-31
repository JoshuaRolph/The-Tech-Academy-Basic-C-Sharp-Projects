using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Employee
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { firstName = "George", lastName = "Lucas" };

            sam.SayName();
            Console.ReadLine();
        }
    }
}
