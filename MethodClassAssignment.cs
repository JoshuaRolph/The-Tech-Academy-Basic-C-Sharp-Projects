using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignmentSubmission
{


        public class MathOperations
    {
        // Void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a mathematical operation on the first integer (e.g., square it)
            int result = num1 * num1;

            // Display the second integer to the screen
            Console.WriteLine($"The second integer is: {num2}");

            // Optionally, display the result of the operation
            Console.WriteLine($"The square of the first integer is: {result}");
            Console.ReadLine();
        }
    }

}
