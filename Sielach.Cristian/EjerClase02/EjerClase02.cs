using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase02
{
    class EjerClase02
    {
        static void Main(string[] args)
        {
            EntidadSello.Sello.mensaje = "Hola";
            EntidadSello.Sello.color = ConsoleColor.Red;
            
            EntidadSello.Sello.imprimir();
            EntidadSello.Sello.color = ConsoleColor.Gray;
            Console.Write("Pulse una tecla para continuar.");
            Console.ReadKey();
            
            EntidadSello.Sello.borrar();
            Console.Write("Pulse una tecla para salir.");
            Console.ReadKey();
        }
    }
}
