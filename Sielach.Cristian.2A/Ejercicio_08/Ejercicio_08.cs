using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_08";

            int valorHs;
            string nombre;
            int anios;
            int hsTotales;
            int importe;

            Console.Write("ingrese el valor por hora: ");
            valorHs = int.Parse(Console.ReadLine());
            Console.Write("ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese la antiguedad (en años): ");
            anios = int.Parse(Console.ReadLine());
            Console.Write("ingrese las horas trabajadas en el mes: ");
            hsTotales = int.Parse(Console.ReadLine());

            importe = ((hsTotales * valorHs) + (anios * 150));
            importe = importe - (importe * 13 / 100);

            Console.Clear();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Antiguedad: {0} años", anios);
            Console.WriteLine("Valor por hora: ${0}", valorHs);
            Console.WriteLine("Total a cobrar: ${0}", importe);
            Console.ReadKey();
        }
    }
}
