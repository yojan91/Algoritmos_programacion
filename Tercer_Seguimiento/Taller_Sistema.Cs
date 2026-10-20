using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{

    internal class Program
    {
        static void Main(string[] args)
        {

            int cantidadArchivos = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de archivos a Descargar: ");
                if (!int.TryParse(Console.ReadLine(), out cantidadArchivos)) {
                    cantidadArchivos = 0;
                }
            } while (cantidadArchivos <= 0);

            int archivosDescargados = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArchivos; i++)
            {
                Console.WriteLine($"\nArchivo #{i}-Nombre (Escriba `Salir` para detener): ");
                string nombre = Console.ReadLine().Trim();
                if (nombre.ToLower() == "salir")
                {
                    Console.WriteLine(">> Proceso de descargar Cancelado!!!");
                    break;
                }
                Console.WriteLine("Tamaño en MB: ");
                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <=0) {
                    Console.WriteLine(">> Tamaño invalido. Archivo omitido");
                    continue;

                }
                Console.WriteLine($">> Descargando `{nombre}` ({tamanio} MB)... OK");
                archivosDescargados++;
                totalMB += tamanio;
            }
            Console.WriteLine("\n======= RESUMEN DE DESCARGA =======");
            Console.WriteLine($"Archivos Desacargados: {archivosDescargados}");
            Console.WriteLine($"Total descargado: {totalMB} MB");
            Console.WriteLine("=======================================");
        }

    }
}
