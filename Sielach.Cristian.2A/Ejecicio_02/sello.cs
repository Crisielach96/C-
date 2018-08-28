using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Sello
  {
    public static string mensaje;
    public static ConsoleColor color;

    public static string imprimir()
    {
      return mensaje;
    }

    public static void borrar()
    {
      mensaje = "Mensaje borrado";
    }
    public static void ImprimirColor()
    {
      Console.BackgroundColor = Sello.color;
      Sello.imprimir();
      //Console.BackgroundColor = ConsoleColor.White;
    }
  }

}
