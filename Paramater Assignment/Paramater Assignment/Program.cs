using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramater_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strEmployee = new Employee<string>();
            Employee<int> intEmployee = new Employee<int>();

            strEmployee.Id = new List<string>() { "John", "Jacob", "Schmidt", "Bob" };

            intEmployee.Id = new List<int>() { "1", "2", "3", "4" };

            foreach (string words in strEmployee.Id)
            {
                Console.WriteLine(words);
            }
            foreach (int num in intEmployee.Id )
            {
                Console.WriteLine(num);
            }
        }
    }
}
