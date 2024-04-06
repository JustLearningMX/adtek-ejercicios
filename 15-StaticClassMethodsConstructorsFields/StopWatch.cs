using System;

namespace _15_StaticClassMethodsConstructorsFields
{
    public class StopWatch
    {
        public static int NoOfInstances = 0;

        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }

        public void PrintNoInstances()
        {
            Console.WriteLine(NoOfInstances);
        }
    }
}