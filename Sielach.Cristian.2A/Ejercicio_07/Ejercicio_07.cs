using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";

            byte dia;
            byte mes;
            int anio;
            int diasTot = 0;

            Console.Write("Ingrese dia de nacimiento: ");
            dia = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese mes de nacimiento: ");
            mes = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese año de nacimiento: ");
            anio = int.Parse(Console.ReadLine());

            for(int i=anio;i<=DateTime.Today.Year;i++)
            {
                if(i % 4 == 0 && !(i % 100 == 0))
                {
                    diasTot++;
                }
                else if (i % 400 == 0)
                {
                    diasTot++;
                }
            }

            diasTot += (DateTime.Today.Year - anio) * 365;

            Console.WriteLine("Usted vivio {0} dias",diasTot);
            Console.ReadKey();
        }
    }
}
