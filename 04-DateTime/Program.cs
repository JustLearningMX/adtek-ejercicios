using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime();
            Console.WriteLine("El valor del dt1 es {0}", dt1);

            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine("El valor del dt2 es {0}", dt2);

            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine("El valor del dt3 es {0}", dt3);

            DateTime dt4 = new DateTime(2015, 12, 31, 21, 10, 20, DateTimeKind.Utc);
            Console.WriteLine("El valor del dt4 es {0}", dt4);
            Console.WriteLine("El valor del dt4 es {0}", dt4.ToLocalTime());

            //Creacion de fechas con Ticks
            DateTime dt5 = new DateTime(636370000000000000);
            Console.WriteLine("El valor del dt4 es {0}", dt5.ToLocalTime());

            //Conversion
            var fechaCadena = "21/12/2020";
            DateTime dt6;

            bool isValidDate = DateTime.TryParse(fechaCadena, out dt6);

            if (isValidDate)
            {
                Console.WriteLine("Fecha convertida es {0}", dt6);
            }
            else
            {
                Console.WriteLine("Fecha no valida");
            }

        }
    }
}
