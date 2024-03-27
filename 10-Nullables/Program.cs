using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine(i.HasValue);
        }
    }
}
