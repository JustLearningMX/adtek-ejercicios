using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ObjectInitializerSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };

            Console.WriteLine("Student ID: {0}", std.StudentID);

            var student1 = new Student() { StudentID = 1, StudentName = "John" };
            var student2 = new Student() { StudentID = 2, StudentName = "Steve" };
            var student3 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student4 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student5 = new Student() { StudentID = 5, StudentName = "Ron" };

            IList<Student> studentList = new List<Student>() {
                student1,
                student2,
                student3,
                student4,
                student5
            };

            IList<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John"} ,
                new Student() { StudentID = 2, StudentName = "Steve"} ,
                new Student() { StudentID = 3, StudentName = "Bill"} ,
                new Student() { StudentID = 3, StudentName = "Bill"} ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron" }
            };

            IList<Student> studentList3 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John"} ,
                null
            };
        }
    }
}
