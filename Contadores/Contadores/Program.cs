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
            Console.WriteLine("Escriba el numero de iterciones que desea: ");
            int valorFinal = int.Parse(Console.ReadLine());
           // int contador = 0;
           // int numero1 = 0;
           // int valor dinal = 0;


            for (int contador = 1; contador <= valorFinal; contador++)
            {
                Console.WriteLine("Escriba el numero " + contador);
            }

            Console.ReadKey();
        }
    }
}
