using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crea un programa en C# que solicite al usuario 5 numero enteros. 
             * Utiliza una estructura repetitiva For para leer los numeros y contar cuantos de ellos 
             * son positivos. ( Al finalizar, muestra en pantalla las cantidades de numeros positivos) */

            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el numero" + i + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0) contador++;

            }
            Console.WriteLine("Cantidad de numero positivos es: " + contador);
        }
    }
}
