using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_StaticClassMethodsConstructorsFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable

            Console.WriteLine($"Calculator Type: {Calculator.Type}");

            Calculator.Type = "Scientific"; // assign value to static variable

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Calculator Type: {Calculator.Type}");

            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4

            sw1.PrintNoInstances(); //4
            sw2.PrintNoInstances(); //4
            sw3.PrintNoInstances(); //4
            sw4.PrintNoInstances(); //4
        }
    }
}
