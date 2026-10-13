using System;

public class helloWorld {

    public static void Main(string[] args) {
        int numero;
        int suma = 0;
        int contador = 0;

        do{
            Console.WriteLine("Ingrese un Numero (0 para salir)");
            numero = int.Parse(Console.ReadLine());
            if (numero != 0)
            {
                suma += numero;
                contador++;
            }

        } while (numero != 0);

        Console.WriteLine($"\nsuma total: {suma}");
        Console.WriteLine($"Cantidad de numero es: {contador}");

        if (contador > 0)
        {
            Console.WriteLine($"promedio: {(double)suma / contador:F2}");
        }
        else
        {
            Console.WriteLine($"No se ingresaron numeros");
        }


    }    
}
