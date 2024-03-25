using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Dynamics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 10;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            d = "Hello";
            Console.WriteLine(d);
        }
    }
}
