using System;


public class Helloworld {
    public static void Main(string[] args) {

        const string passCorrecta = "yojan123";
        string clave;
        int intentosFallidos = 0;

        do
        {
            Console.WriteLine("Ingrese la contraseña: ");
            clave = Console.ReadLine();
            if (clave != passCorrecta) {
                intentosFallidos++;
                Console.WriteLine("Contraseña Incorrecta. Intentalo de nuevo.");
            }
        } while (clave != passCorrecta);
        Console.WriteLine("\n Acceso concedido.");
        Console.WriteLine($"Intentos Fallidos: {intentosFallidos}");


    }

}
