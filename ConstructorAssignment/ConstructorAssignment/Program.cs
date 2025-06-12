using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string const1 = "Name?";
            const string const2 = "Favorite Number?";
            Console.WriteLine("Enter your name or favorite number: ");

            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x)) 
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
