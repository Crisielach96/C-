using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
  class Ejercicio_01
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio_01";

      float sumaTotal=0;
      float min = 0;
      float max = 0;
      float promedio;
      float numero;

      for(int i=0;i<5;i++)
      {
          Console.Write("Ingrese un nuemro: ");
          numero = float.Parse(Console.ReadLine());

        if(i==0)
        {
          max = numero;
          min = numero;
        }

        if(numero<min)
        {
          min = numero;
        }

        if(numero>max)
        {
          max = numero;
        }

        sumaTotal += numero;
      }

    promedio = sumaTotal / 5;
      Console.WriteLine("Suma total: {0}  Promedio: {1:0.00}  Minimo: {2}  Maximo: {3}", sumaTotal, promedio, min, max);
      Console.ReadKey();
    }
  }
}
