using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";

            float numero;

            Console.Write("Ingrese un nuemro: ");
            numero = float.Parse(Console.ReadLine());

            while (numero <= 0)
            {
                Console.Write("Error! Reingrese numero: ");
                numero = float.Parse(Console.ReadLine());
            }

            for (int i=1;i<(numero+1);i++)
            {
                int cont = 0;
                for(int j=1;j<(i+1);j++)
                {
                    if(i%j==0)
                    {
                        cont++;
                    }
                }
                if(cont==2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
