using System;

namespace CodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Josh" };

                db.Students.Add(stud);
                db.SaveChanges();
            }
        }
    }


}
