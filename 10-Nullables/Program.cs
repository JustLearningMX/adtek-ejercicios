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

            int? j = null;
            Console.WriteLine(j.HasValue);

            int h = j ?? 0; // Si j trae un valor, se asigna a h, si no, se asigna 0
        }
    }
}
