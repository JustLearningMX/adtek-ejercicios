﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }

            x = 125;

            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} is an even value");
                    break;
                case 1:
                    Console.WriteLine($"{x} is an odd Value");
                    break;
            }

            x = 125;
            Console.Write(isOdd(x) ? "Even value" : "Odd value");

            string statementType = "switch";

            switch (statementType)
            {
                case "if.else":
                    Console.WriteLine("if...else statement");
                    break;
                case "ternary":
                    Console.WriteLine("Ternary operator");
                    break;
                case "switch":
                    Console.WriteLine("switch statement");
                    break;
            }

            // C# Combined Switch Cases
            x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;
            }

            // Nested switch statements
            int j = 5;

            switch (j)
            {
                case 5:
                    Console.WriteLine(5);
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15:
                    Console.WriteLine(15);
                    break;
                default:
                    Console.WriteLine(100);
                    break;
            }
        }

        static bool isOdd(int x)
        {
            switch (x % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;
                default:
                    return false;
            }

            return false;
        }
    }
}
