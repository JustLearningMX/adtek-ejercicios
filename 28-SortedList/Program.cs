using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_SortedList
{
    public class Program
    {
        static void Main(string[] args)
        {

            SortedList<int, string> numberNamesExample = new SortedList<int, string>();
            numberNamesExample.Add(3, "Three");
            numberNamesExample.Add(1, "One");
            numberNamesExample.Add(2, "Two");
            numberNamesExample.Add(4, null);
            numberNamesExample.Add(10, "Ten");
            numberNamesExample.Add(5, "Five");

            SortedList<string, string> cities = new SortedList<string, string>()
            {
                {"London", "UK"},
                {"New York", "USA"},
                { "Mumbai", "India"},
                {"Johannesburg", "South Africa"}
            };

            SortedList<int, string> numberNames = new SortedList<int, string>()
            {
                {3, "Three"},
                {5, "Five"},
                {1, "One"}
            };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            //Access SortedList Values
            SortedList<int, string> numberNames3 = new SortedList<int, string>()
            {
                {3, "Three"},
                {1, "One"},
                {2, "Two"}
            };

            Console.WriteLine(numberNames3[1]); //output: One
            Console.WriteLine(numberNames3[2]); //output: Two
            Console.WriteLine(numberNames3[3]); //output: Three
            //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            numberNames3[2] = "TWO"; //updates value
            numberNames3[4] = "Four"; //adds a new key-value if a key does not exists

        }


    }
}
