using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejecicio_02
{
  class Program
  {
    static void Main(string[] args)
    {
      Sello.color = ConsoleColor.Red;
      Sello.mensaje = "SACA LA MANO DE AHI CARAJO!!";
      Console.WriteLine(Sello.imprimir());
      Console.ReadKey();
      Console.Clear();
      Sello.borrar();
      Sello.ImprimirColor();
      Console.WriteLine(Sello.imprimir());
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ReadKey();
      Console.Clear();
      Sello.mensaje = "SACA LA MANO DE AHI CARAJO!!";
      Console.WriteLine(Sello.imprimir());
      Console.ReadKey();
      Console.ReadKey();
    }
  }
}
