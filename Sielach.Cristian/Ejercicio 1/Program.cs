using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            float minimo = 0;
            float maximo = 0;
            float sumador = 0;
            float numero;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un Numero: ");
                numero = float.Parse(Console.ReadLine());
                
                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    numero = minimo;
                }

                sumador += numero;
            }
            promedio = sumador / 5;

            Console.WriteLine("Minimo = {0} Maximo = {1} Suma Final = {2} Promedio = {3}", minimo, maximo, sumador, promedio);
            Console.ReadKey();
        }

    }
}
