
using System;

namespace Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double espacioDisponible = 0;

            do
            {
                Console.WriteLine("Ingrese el espacio total disponible en disco (MB): ");

                if (!double.TryParse(Console.ReadLine(), out espacioDisponible))
                {
                    espacioDisponible = 0;
                }

                if (espacioDisponible <= 0)
                {
                    Console.WriteLine(">> El espacio debe ser mayor a 0.");
                }

            } while (espacioDisponible <= 0);

            int cantidadArchivos = 0;

            do
            {
                Console.WriteLine("Ingrese la cantidad de archivos a Descargar: ");

                if (!int.TryParse(Console.ReadLine(), out cantidadArchivos))
                {
                    cantidadArchivos = 0;
                }

            } while (cantidadArchivos <= 0);

            int archivosDescargados = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArchivos; i++)
            {
                Console.WriteLine($"\nArchivo #{i}-Nombre (Escriba 'Salir' para detener): ");

                string nombre = (Console.ReadLine() ?? "").Trim();

                if (nombre.ToLower() == "salir")
                {
                    Console.WriteLine(">> Proceso de descarga cancelado!!!");
                    break;
                }

                if (nombre.Length == 0 || nombre.Length > 20)
                {
                    Console.WriteLine(">> Nombre de archivo inválido. Omitido.");
                    continue;
                }

                Console.WriteLine("Tamaño en MB: ");

                double tamanio = 0;

                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">> Tamaño inválido. Archivo omitido.");
                    continue;
                }

                if (tamanio > espacioDisponible)
                {
                    Console.WriteLine(">> Espacio insuficiente en disco. Descarga detenida.");
                    break;
                }

                espacioDisponible -= tamanio;

                Console.WriteLine($">> Descargando '{nombre}' ({tamanio} MB)... OK");

                archivosDescargados++;
                totalMB += tamanio;

                if (tamanio < 1)
                {
                    Console.WriteLine("Categoría: Pequeño");
                }
                else if (tamanio <= 10)
                {
                    Console.WriteLine("Categoría: Mediano");
                }
                else
                {
                    Console.WriteLine("Categoría: Grande");
                }

                Console.WriteLine($"Espacio restante: {espacioDisponible} MB");
            }

            Console.WriteLine("\n======= RESUMEN DE DESCARGA =======");
            Console.WriteLine($"Archivos descargados: {archivosDescargados}");
            Console.WriteLine($"Total descargado: {totalMB} MB");
            Console.WriteLine($"Espacio disponible restante: {espacioDisponible} MB");
            Console.WriteLine("===================================");
        }
    }
}


          

