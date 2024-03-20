using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estructura sin constructor
            Coordinate point = new Coordinate();
            point.x = 5;
            point.y = 10;
            point.PrintCoordinates();

            //Estructura con constructor
            Coordinate point2 = new Coordinate(10, 20);
            point2.PrintCoordinates();

            //Estructura con método
            Coordinate point3 = new Coordinate(15, 25);
            point3.PrintCoordinates();
            point3.SetOrigin();
            point3.PrintCoordinates();

            //Estructura con método estático
            Coordinate point4 = Coordinate.GetOrigin();
            point4.PrintCoordinates();

            //Estructura con evento
            Coordinate2 point5 = new Coordinate2();
            point5.CoordinatesChanged += notifica;
            point5.x = 10;
            point5.y = 20;

        }

        static void notifica(int point)
        {
            Console.WriteLine("Coordinates changed: " + point);
        }
    }
}
