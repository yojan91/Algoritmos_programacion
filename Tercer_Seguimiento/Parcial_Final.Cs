using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuarioCorrecto = "soporteDB";
            string contraseñaCorrecta = "Sistemas2026";

            string usuario;
            string contraseña;

            int intentos = 0;
            bool conexionExitosa = false;
            do
            {
                Console.WriteLine("======================================");
                Console.WriteLine(" VALIDACION DE CONEXION A BASE DE DATOS");
                Console.WriteLine("======================================");

                Console.Write("Ingrese su usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Ingrese su contraseña: ");
                contraseña = Console.ReadLine();
                if (usuario == "admin")
                {
                    Console.WriteLine("\nServidor no disponible. Reintente más tarde.\n");
                }
                else if (usuario == usuarioCorrecto &&
                         contraseña == contraseñaCorrecta)
                {
                    Console.WriteLine("\nConexión establecida con la base de datos.");

                    conexionExitosa = true;
                }
                else
                {
                    intentos++;

                    Console.WriteLine("\nError de autenticación. Intento "
                        + intentos + " de 3.\n");
                }

            } while (intentos < 3 && conexionExitosa == false);
            if (conexionExitosa == false && intentos == 3)
            {
                Console.WriteLine("Conexión bloqueada por seguridad.");
                Console.WriteLine("Comuníquese con el administrador del sistema.");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
