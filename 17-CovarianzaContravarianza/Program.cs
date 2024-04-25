using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CovarianzaContravarianza
{
    internal class Program
    {

        public delegate Small CovarianzaDelegate(Big mc);

        static void Main(string[] args)
        {
            Small small = new Small();
            small.id = 1;
            small.nombre = "Small";

            Big big = new Big();
            big.id = 2;
            big.nombre = "Big";
            big.descripcion = "Big Description";

            Bigger bigger = new Bigger();
            bigger.id = 3;
            bigger.nombre = "Bigger";
            bigger.descripcion = "Bigger Description";
            bigger.tamano = 100;

            // Covarianza
            // Covarianza es la capacidad de devolver un tipo más derivado que el especificado en la definición original
            // de un método de una clase base. En otras palabras, la covarianza permite que un método devuelva un tipo más
            // derivado que el especificado en la definición original de la clase base.
            // La covarianza se aplica a los tipos de retorno de los métodos y a los tipos de las propiedades.

            CovarianzaDelegate covarianzaDelegate = Method1;
            Small big2 = covarianzaDelegate(new Big());

            covarianzaDelegate = Method2;
            Small small2 = covarianzaDelegate(new Big());

        }

        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }

        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }
    }

    public class Small
    {
        public int id { get; set; }
        public string nombre { get; set; }

    }

    public class Big : Small
    {
        public string descripcion { get; set; }
    }

    public class Bigger : Big
    {
        public int tamano { get; set; }
    }
}
