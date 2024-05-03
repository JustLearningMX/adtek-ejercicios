using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ArrayMultidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Arrays multidimensionales
            /*int[,] array2D = new int[3, 3];
            int[,,] array3D = new int[3, 3, 3];
            int[,,,] array4D = new int[3, 3, 3, 3];
            int[,,,,] array5D = new int[3, 3, 3, 3, 3];*/

            //Inicializacion de Arrays de 2 dimensiones
            int[,] array2D_1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array2D_2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Leer un valor de un array multidimensional uno a uno
            /*Console.WriteLine($"array2D_1[0, 0] = {array2D_1[0, 0]}");
            Console.WriteLine($"array2D_1[1, 1] = {array2D_1[0, 1]}");
            Console.WriteLine($"array2D_1[1, 1] = {array2D_1[0, 2]}");
            Console.WriteLine($"array2D_1[2, 2] = {array2D_1[1, 0]}");
            Console.WriteLine($"array2D_1[2, 2] = {array2D_1[1, 1]}");
            Console.WriteLine($"array2D_1[2, 2] = {array2D_1[1, 2]}");
            Console.WriteLine($"array2D_1[2, 2] = {array2D_1[2, 0]}");
            Console.WriteLine($"array2D_1[2, 2] = {array2D_1[2, 1]}");
            Console.WriteLine($"array2D_1[2, 2] = {array2D_1[2, 2]}");*/

            // Leer un valor de un array multidimensional con un bucle
            int i = 0;
            while (i < 3)
            {
                int j = 0;

                while (j < 3)
                {
                    int numero = array2D_1[i, j];
                    Console.WriteLine($"La fila {i} y columna {j} tiene un valor de {numero}");
                    j++;
                }

                i++;
            }

        }
    }
}
