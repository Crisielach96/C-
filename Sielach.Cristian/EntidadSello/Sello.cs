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
            devuelve = "";
            bool validacion=false;
           
            if(mensaje != "")
           {
               validacion = true;
               devuelve=EntidadSello.Sello.ArmarFormatoMensaje();
           }
            return validacion;
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
            Console.Write(encuadre);
            Console.Write("\n");
            Console.Write("*");
            Console.Write(EntidadSello.Sello.mensaje);
            Console.Write("*\n");
            Console.WriteLine(encuadre);
            
        }

        public static void imprimir()
        {
            Console.ForegroundColor = Sello.color;
            Sello.ArmarFormatoMensaje();
        }
        
        public static void borrar()
        {
            Console.Clear();
        }
    }
}
