using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadSello
{
    public class Sello
    {
        public static string mensaje;

        public static ConsoleColor color;

        public static bool tryParse(string mensaje , out string devuelve)
        {
            bool resp = false;
            int cant = mensaje.Length;

            if(cant != 0)
            {
                devuelve = EntidadSello.Sello.ArmarFormatoMensaje();
                resp = true;
            }
            else
            {
                devuelve = "";
            }

            return resp;
        }
        
        private static string ArmarFormatoMensaje()
        {
            int largo;
            string encuadre = "";
            
            largo=Sello.mensaje.Length;

            for(int i=0;i<largo+2;i++)
            {
                encuadre += "*";
            }
            encuadre += "\n";
            encuadre += "*";
            encuadre += Sello.mensaje;
            encuadre += "*\n";

            for (int i = 0; i < largo + 2; i++)
            {
                encuadre += "*";
            }

            return encuadre;
        }

        public static void imprimir()
        {
            bool ok = tryParse(mensaje, out mensaje);

            if(ok)
            {
                color = ConsoleColor.DarkRed;
                Console.ForegroundColor = Sello.color;
                Console.WriteLine("{0}", Sello.mensaje);
                EntidadSello.Sello.color = ConsoleColor.DarkGray;
                Console.ForegroundColor = EntidadSello.Sello.color;
            }
            else
            {
                Console.WriteLine("\nError\n");
            }
        }
        
        public static void borrar()
        {
            Console.Clear();
        }
    }
}
