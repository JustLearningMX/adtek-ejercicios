using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_MatricesIrregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jArray = new int[2][]{
                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7}
            };

            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < (jArray[i]).Length; j++)
                    Console.WriteLine(jArray[i][j]);
            }
        }
    }
}
