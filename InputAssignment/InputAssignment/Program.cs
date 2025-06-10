using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to input a number. //
            Console.WriteLine("Enter a random number...");
            // Taking the users inputted number. //
            int num = Convert.ToInt32(Console.ReadLine());
            //Thanking the user for their input. //
            Console.WriteLine("Thanks for your input. It has been Logged.");
            // Logging their input into a .txt file in the Logs folder. //
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\jrolp\Documents\\Logs\\Input.txt", true))
            {
                file.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
