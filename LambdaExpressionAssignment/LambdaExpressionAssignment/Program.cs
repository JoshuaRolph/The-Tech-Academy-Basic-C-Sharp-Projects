using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> campus = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Bob", lastName = "Dingus" },
                new Employee() { Id = 2, firstName = "Bob", lastName = "McMahon" },
                new Employee() { Id = 3, firstName = "Joshua", lastName = "McDouglas" },
                new Employee() { Id = 4, firstName = "Johnathan", lastName = "McDougall" },
                new Employee() { Id = 5, firstName = "Erik", lastName = "Dog" },
                new Employee() { Id = 6, firstName = "Liam", lastName = "Chicken" },
                new Employee() { Id = 7, firstName = "Charles", lastName = "Ding" },
                new Employee() { Id = 8, firstName = "Bob", lastName = "Bobaganoosh" },
                new Employee() { Id = 9, firstName = "Bob", lastName = "Bill" },
                new Employee() { Id = 10, firstName = "Bill", lastName = "Bob" },
                new Employee() { Id = 11, firstName = "Phil", lastName = "McCracken" },
                new Employee() { Id = 12, firstName = "Bam", lastName = "Allama" },
                new Employee() { Id = 13, firstName = "Banan", lastName = "aRama" },
                new Employee() { Id = 14, firstName = "Pilsbury", lastName = "DoBoy" },
            };

            // a foreach loop, creating a new list of employees with the first name bob // 
            list<employee> bobs = new list<employee>();
            foreach (employee employee in campus)
            {
                if (employee.firstname == "bob")
                {
                    bobs.add(employee);
                }
            }

            // now trying the lambda expression //
            list<employee> bobs2 = campus.where(x => x.id > 5).tolist();
            // use lambda expression, to make a list of all employees with an id number greater than 5 //
            list<employee> bigid = campus.where(x => x.id > 5).tolist();
            Console.ReadLine();
         }       
    }
}
