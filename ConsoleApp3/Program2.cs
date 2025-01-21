using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de dos dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        // Que el numero sea de dos numeros
        if (numero >= 10 && numero <= 99 || numero <= -10 && numero >= -99)
        {
            // Verificar es primo
            bool esPrimo = EsPrimo(Math.Abs(numero));

            // Verificar si es negativo
            bool esNegativo = numero < 0;

            //esultados
            Console.WriteLine($"El número {numero} es {(esPrimo ? "primo" : "no primo")}.");
            Console.WriteLine($"El número {numero} es {(esNegativo ? "negativo" : "positivo")}.");
        }
        else
        {
            Console.WriteLine("El número ingresado no es de dos dígitos.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false; // Los números menores a 2 no son primos

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false; // Si tiene un divisor, no es primo
            }
        }

        return true; // Es primo si no tiene divisores
    }
}
