using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Structures
{
    internal struct Coordinate
    {
        //Atributos
        public int x { get; set; }
        public int y { get; set; }

        //Constructor
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Método que Establece el origen de coordenadas
        public void SetOrigin() 
        {
            this.x = 0;
            this.y = 0;
        }

        //Método que imprime las coordenadas
        public void PrintCoordinates()
        {
            Console.WriteLine("X: " + this.x + " Y: " + this.y);
        }

        //Métodos estáticos
        public static Coordinate GetOrigin()
        {
            return new Coordinate();
        }
    }
}
