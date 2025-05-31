using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismAssignment
{
    // Employee class that inherits from IQuittable //
    public class Employee : IQuittable
    {
        // Implementing the Quit method //
        public void Quit()
        {
        Console.WriteLine("I Quit");
        }
    }
}
