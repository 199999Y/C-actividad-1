using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de dos dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        // Validar que el número sea de dos dígitos
        if (numero >= 10 && numero <= 99 || numero <= -10 && numero >= -99)
        {
            // Obtener los dígitos
            int unidad = Math.Abs(numero % 10);  // Último dígito
            int decena = Math.Abs(numero / 10); // Primer dígito

            // Verificar si ambos dígitos son primos
            bool unidadEsPrimo = EsPrimo(unidad);
            bool decenaEsPrimo = EsPrimo(decena);

            // Mostrar resultados
            Console.WriteLine($"El dígito de las unidades ({unidad}) es {(unidadEsPrimo ? "primo" : "no primo")}.");
            Console.WriteLine($"El dígito de las decenas ({decena}) es {(decenaEsPrimo ? "primo" : "no primo")}.");

            if (unidadEsPrimo && decenaEsPrimo)
            {
                Console.WriteLine("Ambos dígitos son primos.");
            }
            else
            {
                Console.WriteLine("Solo un digito es primos.");
            }
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
