using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            Array.Sort(nums); // sorts array 
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search 

            int[] nums2 = { 1, 2, 3, 4, 5 };

            UpdateArray(nums2);

            foreach (var item in nums2)
                Console.WriteLine(item);


        }

        public static void UpdateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] + 10;
        }
    }
}
