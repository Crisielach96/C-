using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            double cuadrado = 0;
            double cubo = 0;
            double numero;

            Console.WriteLine("Ingrese un Numero: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
            }
            else 
            {
                Console.WriteLine("Error, el numero debe ser mayor a 0");
            }

            Console.WriteLine("Numero = {0}  Cuadrado = {1}  Cubo = {2}", numero, cuadrado, cubo);
            Console.ReadKey();
        }
    }
}
