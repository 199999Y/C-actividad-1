using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de tres dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 100 && numero <= 999 || numero <= -100 && numero >= -999)
        {
            // Obtener los dígitos
            int unidad = Math.Abs(numero % 10);         // Último dígito
            int decena = Math.Abs((numero / 10) % 10); // Segundo dígito
            int centena = Math.Abs(numero / 100);      // Primer dígito

            // Verificar si son multiplos
            bool unidadEsMultiplo = (unidad != 0) && (decena % unidad == 0 || centena % unidad == 0);
            bool decenaEsMultiplo = (decena != 0) && (unidad % decena == 0 || centena % decena == 0);
            bool centenaEsMultiplo = (centena != 0) && (unidad % centena == 0 || decena % centena == 0);

            //Resultados
            if (unidadEsMultiplo)
                Console.WriteLine($"El dígito de las unidades ({unidad}) es múltiplo de otro dígito.");
            if (decenaEsMultiplo)
                Console.WriteLine($"El dígito de las decenas ({decena}) es múltiplo de otro dígito.");
            if (centenaEsMultiplo)
                Console.WriteLine($"El dígito de las centenas ({centena}) es múltiplo de otro dígito.");

            if (!unidadEsMultiplo && !decenaEsMultiplo && !centenaEsMultiplo)
                Console.WriteLine("Ningún dígito es múltiplo de los otros.");
        }
        else
        {
            Console.WriteLine("El número ingresado no es de tres dígitos.");
        }
    }
}
