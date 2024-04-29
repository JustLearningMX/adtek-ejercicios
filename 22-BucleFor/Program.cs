using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_BucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            /*If a code block only contains a single statement, then you don't need to wrap it inside curly brackets { }, as shown below.

                Example: for Loop*/
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Value of i: {0}", i);

            /*An Initializer, condition, and iterator sections are optional. You can initialize a variable before for loop, and condition and iterator can be defined inside a code block, as shown below.

                Example: for loop C#*/
            /*int j = 0;

            for (; ; )
            {
                if (j < 10)
                {
                    Console.WriteLine("Value of i: {0}", j);
                    j++;
                }
                else
                    break;
            }*/

            // Multiple Expressions
            for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }
        }
    }
}
