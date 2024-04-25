﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_StatementsIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicios IF
             int i = 10, j = 20;

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }

            if (i > 1)
            {
                Console.WriteLine("i is less than j");
            }

            if (i < j)
            {
                Console.WriteLine("i is greater than j");
            }

            if (isGreater(i, j))
            {
                Console.WriteLine("i is less than j");
            }

            if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }*/

            /*Ejercicios IF - ELSE IF*/
            int i = 10, j = 20;

            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }
            else if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }


            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
                Console.WriteLine("i is equal to j");


        }

        static bool isGreater(int i, int j)
        {
            return i > j;
        }
    }
}
