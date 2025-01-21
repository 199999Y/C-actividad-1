using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer número entero de dos dígitos: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número entero de dos dígitos: ");
        int numero2 = int.Parse(Console.ReadLine());

        
        if (EsDosDigitos(numero1) && EsDosDigitos(numero2))
        {
            
            int suma = numero1 + numero2;

           
            bool esPar = suma % 2 == 0;

            
            Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}, y es {(esPar ? "par" : "impar")}.");
        }
        else
        {
            Console.WriteLine("Uno o ambos números ingresados no son de dos dígitos.");
        }
    }

    static bool EsDosDigitos(int numero)
    {
        return numero >= 10 && numero <= 99 || numero <= -10 && numero >= -99;
    }
}

