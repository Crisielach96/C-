using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase02
{
    class sello
    {
        public static string mensaje;
        
        public static void imprimir()
        {
            Console.WriteLine("{0}", sello.mensaje); 
        }
        public static void borrar()
        {
            Console.Clear();
        }
    }
}
