using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arlist1 = new ArrayList();

            var arlist2 = new ArrayList()
            {
                1, "Bill", " ", true, 4.5, null
            };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 

            foreach (var item in arlist1)
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

        }
    }
}
