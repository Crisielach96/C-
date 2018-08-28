using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";
            
            int cont = 0;

            Console.WriteLine("Los primeros 4 numeros perfectos son: ");

            for (int i = 1; ; i++)
            {
                int acum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acum += j;
                    }
                }
                if (acum == i)
                {
                    Console.WriteLine(i);
                    cont++;
                }
                if (cont == 4)
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
