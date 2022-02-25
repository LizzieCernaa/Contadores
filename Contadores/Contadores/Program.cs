using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agrege Numerico");
            int numero1 = int.Parse(Console.ReadLine());
           // int contador = 0;
           // int numero1 = 0;
           // int contador2 = 0;


            for (int contador = 0; contador <= numero1; contador++)
            {
                Console.WriteLine("Ejecutando interacion numero " + contador);
            }

            Console.ReadKey();
        }
    }
}
