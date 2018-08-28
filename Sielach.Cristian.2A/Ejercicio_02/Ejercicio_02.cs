using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            double numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un nuemro: ");
            numero = float.Parse(Console.ReadLine());

            while(numero<=0)
            {
                Console.Write("Error! Reingrese numero: ");
                numero = float.Parse(Console.ReadLine());
            }
            cubo = Math.Pow(numero,3);
            cuadrado = Math.Pow(numero, 2);

            Console.Write("El numero es: {0:#,###.00}\n" +
                          "Su cuadrado es: {1:#,###.00}\n" +
                          "Su cubo es: {2:#,###.00}", numero,cuadrado,cubo);

            Console.ReadKey();
        }
    }
}
