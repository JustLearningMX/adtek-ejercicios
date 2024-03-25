using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");

            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }

            Console.WriteLine(sb.ToString());

            StringBuilder sb2 = new StringBuilder("Tu cantidad total es: ");

            sb2.AppendFormat("{0:C}", 25);

            Console.WriteLine(sb2.ToString());
        }
    }
}
