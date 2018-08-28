using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            int anio;

            Console.Write("Ingrese un año: ");
            anio = int.Parse(Console.ReadLine());
            if (anio % 4 == 0 && !(anio % 100 == 0))
            {
                Console.WriteLine("el año {0} es bisiesto.", anio);
            }
            else if (anio % 400 == 0)
            {
                Console.WriteLine("el año {0} es bisiesto.", anio);
            }
            else
            {
                Console.WriteLine("el año {0} no es bisiesto", anio);
            }

            Console.ReadKey();
        }
    }
}
