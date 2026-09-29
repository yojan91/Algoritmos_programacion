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
            Console.WriteLine("menu");
            Console.WriteLine("1. Informacion Academica");
            Console.WriteLine("2. mostrar fecha");
            Console.WriteLine("3.  salir");
            Console.WriteLine("Seleccione una opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese su nombre: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Ingrese su Edad");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su genero F/M");
                    string gender = Console.ReadLine();

                    Console.WriteLine("Ingrese su facultad");
                    string faculty = Console.ReadLine();

                    Console.WriteLine("Ingrese su pograma academico");
                    string program = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine(" la fecha actual es:" + DateTime.Now);
                    break;
                case 3:
                    Console.WriteLine(" programa finalizado!!!");
                    break;
                default:
                    Console.WriteLine("Opcion no valida!!");
                    break;
            }
        }
    }
}
