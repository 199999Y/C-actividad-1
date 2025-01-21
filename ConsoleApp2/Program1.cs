using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de dos dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        // Que el numero sea de dos digitos
        if (numero >= 10 && numero <= 99 || numero <= -10 && numero >= -99)
        {
            // Datos
            int unidad = Math.Abs(numero % 10);  // Último dígito
            int decena = Math.Abs(numero / 10); // Primer dígito

            // Suma
            int suma = unidad + decena;

            Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");
        }
        else
        {
            Console.WriteLine("El número ingresado no es de dos dígitos.");
        }
    }
}
