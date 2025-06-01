using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two Employees //
            Employee employee1 = new Employee() { Id = 1, firstName = "Bob", lastName = "Baganoosh" };
            Employee employee2 = new Employee() { Id = 2, firstName = "John", lastName = "SaTool" };

            // Comparing the two Employee Objects //
            if (employee1 == employee2)
            {
                Console.WriteLine("The employees are equal.");

            }

            else
            {
                Console.WriteLine("The employees are NOT equal.");
            }
            // Modifying emp2 to have same Id as emp1 //

            employee2.Id = 1;
                if (employee1 = employee2)
            {
                Console.WriteLine("Employees are NOW equal.");
            }
                else
            {
                Console.WriteLine("They are still NOT equal.");
            }

            Console.ReadLine();
        }
    }
}
