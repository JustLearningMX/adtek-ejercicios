using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PartialClassAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "John");
            emp.DisplayEmpInfo();

            Employee emp1 = new Employee();
            emp1.DisplayEmpInfo();
        }
    }
}
