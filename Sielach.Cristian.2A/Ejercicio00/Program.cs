using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.Title = "Ejercicio00";

            Console.WriteLine("Hola mundo!");

            Console.Write("Ingrese un nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es {0} y su edad es {1}",nombre,edad);

            Console.ReadKey();
        }
    }
}
