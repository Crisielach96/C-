using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";

            int altura;

            Console.Write("ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 0; j < (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
