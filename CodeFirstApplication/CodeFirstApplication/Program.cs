using System;

namespace CodeFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Josh" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
