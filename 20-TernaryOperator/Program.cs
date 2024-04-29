using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example: Ternary operator
            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than y";

            Console.WriteLine(result);

            // Ternary operator replaces if statement
            // Nested ?:
            x = 10;
            y = 100;

            result = x > y ? "x is greater than y" :
                x < y ? "x is less than y" :
                x == y ? "x is equal to y" : "No result";

            Console.WriteLine(result);
        }
    }
}
