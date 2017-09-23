using System;
using System.Globalization;

namespace CreateDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                Firstname = "David",
                Lastname = "Wood",
                DateOfBirth = new DateTime(1969,10,19),
                GPA = 3.95M
            };
           
            using (var context = new StudentContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
