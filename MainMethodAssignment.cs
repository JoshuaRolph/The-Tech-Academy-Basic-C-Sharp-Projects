using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Math Class //
            Math math1 = new Math();
            //First method with int Parameter
            Console.WriteLine(math1.MathOp(15));

            // Second Method with int Parameter //
            Console.WriteLine(math1.MathOp(50));

            // Third Method with int Parameter //
            Console.WriteLine(math1.MathOp(5));
            Console.ReadLine();
        }
    }
}
