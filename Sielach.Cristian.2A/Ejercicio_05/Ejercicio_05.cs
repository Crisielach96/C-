using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercico_05";

            int num;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int acum = 0;
                int acum2 = 0;
                for (int j = 1; j <= (i - 1); j++)
                {
                    acum += j;
                }
                for (int k = (i + 1); acum2 < acum; k++)
                {
                    acum2 += k;

                    if (acum == acum2)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
