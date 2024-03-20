using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student
            {
                id = 1,
                Name = "Jane",
                Surname = "Toe",
            };

            Console.WriteLine(student.Name + " " + student.Surname);

            student.Name = "John";
            student.Surname = "Doe";

            Console.WriteLine(student.Name + " " + student.Surname);

        }
    }
}
