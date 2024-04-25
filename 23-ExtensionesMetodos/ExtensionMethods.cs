using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ExtensionesMetodos
{
    public static class ExtensionMethods
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
