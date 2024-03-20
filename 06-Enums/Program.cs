using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDays day = WeekDays.Monday;
            Console.WriteLine(day);
            
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Sunday);
            Console.WriteLine(WeekDays.Saturday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Monday);
        }
    }
}
