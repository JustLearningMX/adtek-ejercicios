using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Anonymus_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Id = 1, Name = "John Student", Age = 25 };
            var studentAnonymus = new { Id = 22, Name = "John Anonymus", Age = 21 };

            Console.WriteLine("Anonymus student Name: " + studentAnonymus.Name);
            Console.WriteLine("Student Name: " + student.Name);

            var studentAnonymus2 = new
            {
                Id = 22, 
                Name = "John Anonymus", 
                Age = 21,
                Address = new { City = "New York", Street = "Wall Street" }
            };

            Console.WriteLine("Anonymus student Address: " + studentAnonymus2.Address);

            var students = new[]
            {
                new { Id = 1, Name = "Joe Anonymus", Age = 21 },
                new { Id = 2, Name = "Jane Anonymus", Age = 22 },
                new { Id = 3, Name = "Jack Anonymus", Age = 23 }
            };

            foreach (var item in students)
            {
                Console.WriteLine("Anonymus student Name: " + item.Name);
            }

            IList<Student> studentList = new List<Student>
            {
                new Student { Id = 1, Name = "Joe Student", Age = 21 },
                new Student { Id = 2, Name = "Jane Student", Age = 22 },
                new Student { Id = 3, Name = "Jack Student", Age = 23 }
            };

            var studentAnonymusList = from s in studentList
                                      select new { s.Id, s.Name };
            //studentList.Select(s => new { s.Id, s.Name, s.Age });

            foreach (var sList in studentList)
            {
                Console.WriteLine("Student Name: " + sList.Name);
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
