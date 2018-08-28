using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_10";
            
            for (int i = 1; i <= 5; i++)
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
