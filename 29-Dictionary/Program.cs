using System;
using System.Collections.Generic;
using System.Linq;

namespace _29_Dictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1,"One"); //adding a key/value using the Add() method
            numberNames.Add(2,"Two");
            numberNames.Add(3,"Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach(KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
		
            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
		
            foreach(var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var cities2 = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
            //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if(cities2.ContainsKey("France")){  
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if(cities2.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", 
                    cities2.ElementAt(i).Key, 
                    cities2.ElementAt(i).Value);
            }

        }
    }
}