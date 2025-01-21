using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de tres dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        
        if (numero >= 100 && numero <= 999 || numero <= -100 && numero >= -999)
        {
            // Obtener dígitos
            int unidad = Math.Abs(numero % 10); // Último dígito
            int decena = Math.Abs((numero / 10) % 10); // Segundo dígito
            int centena = Math.Abs(numero / 100); // Primer dígito

            // Determinar el mayor dígito
            if (centena >= decena && centena >= unidad)
            {
                Console.WriteLine($"El mayor dígito es {centena} y está en la posición de las centenas.");
            }
            else if (decena >= centena && decena >= unidad)
            {
                Console.WriteLine($"El mayor dígito es {decena} y está en la posición de las decenas.");
            }
            else
            {
                Console.WriteLine($"El mayor dígito es {unidad} y está en la posición de las unidades.");
            }
        }
        else
        {
            Console.WriteLine("El número ingresado no es de tres dígitos.");
        }
    }
}
