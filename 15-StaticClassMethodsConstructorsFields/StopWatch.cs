using System;

namespace _15_StaticClassMethodsConstructorsFields
{
    public class StopWatch
    {
        public static int NoOfInstances = 0;


        public void PrintNoInstances()
        {
            Console.WriteLine(NoOfInstances);
        }

        // static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
            StopWatch.NoOfInstances++;
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }
}