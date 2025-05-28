using System;
using System.Collections.Generic;

namespace StringsandIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 4, 12, 24, 48, 96, 7000, 14000 };
            bool numValid = false;
            while (!numValid)
            {
                try
                {
                    Console.WriteLine("Type a number to divide");
                    float numDivide = float.Parse(Console.ReadLine());
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Don't divide by 0..");
                    }
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid.. Enter a number please..");
                }
            }
            Console.ReadLine();
                
        }
    }
}
