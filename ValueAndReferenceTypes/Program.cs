using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reference type
            int x = 100;
            Console.WriteLine("Value of x before calling changedValue() is: " + x);
            changedValue(x);
            Console.WriteLine("Value of x after calling changedValue() is: " + x);

            //Value type
            Student student = new Student();
            student.ID = 1;
            student.Name = "John";
            Console.WriteLine("Value of student before calling changedValue() is: " + student.ID + " " + student.Name);
            changedValue(student);
            Console.WriteLine("Value of student after calling changedValue() is: " + student.ID + " " + student.Name);

        }


        static void changedValue(int x)
        {
            x = 200;
            Console.WriteLine("Value of x in changedValue() is: " + x);
        }

        static void changedValue(Student student)
        {
            student.ID = 2;
            student.Name = "Steve";
            Console.WriteLine("Value of student in changedValue() is: " + student.ID + " " + student.Name);
        }
    }
}

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
}