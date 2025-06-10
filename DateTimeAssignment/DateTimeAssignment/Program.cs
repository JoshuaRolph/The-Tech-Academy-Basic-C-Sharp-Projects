using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing current date and time to the console.. //
            Console.WriteLine("The date and time is: " + DateTime.Now);
            // Ask for a number... //
            Console.WriteLine("\nPlease enter a random number..");
            float answer = float.Parse(Console.ReadLine());
            // Printing the time that it'll be in the amount of hours the user input.. //
            Console.WriteLine(" {0} + {1} hour(s) = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
        
    }
}
