using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Piramide");
            Console.WriteLine("4. Rombo");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("De que tamaño quieres el cuadrado? ");
                    int tamano = int.Parse(Console.ReadLine());

                    int asteriscos = 0;

                    for (int i = 1; i <= tamano; i++)
                    {
                        for (int j = 1; j <= tamano; j++)
                        {
                            if (i == 1 || i == tamano ||
                                j == 1 || j == tamano)
                            {
                                Console.Write("*");
                                asteriscos++;
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine("Altura: " + tamano);
                    Console.WriteLine("Ancho: " + tamano);
                    Console.WriteLine("Cantidad de asteriscos: " + asteriscos);
                    break;

                case 2:
                    for (int i = 5; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5 - i; j++)
                            Console.Write(" ");

                        for (int k = 1; k <= 2 * i - 1; k++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5 - i; j++)
                            Console.Write(" ");

                        for (int k = 1; k <= 2 * i - 1; k++)
                            Console.Write("*");

                        Console.WriteLine();
                    }

                    for (int i = 4; i >= 1; i--)
                    {
                        for (int j = 1; j <= 5 - i; j++)
                            Console.Write(" ");

                        for (int k = 1; k <= 2 * i - 1; k++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

        } while (opcion != 5);
    }
}
