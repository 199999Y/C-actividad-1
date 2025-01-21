using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de cuatro dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        // Validar que sean 4
        if (numero >= 1000 && numero <= 9999 || numero <= -1000 && numero >= -9999)
        {
            // Convertir el número a su valor absoluto
            numero = Math.Abs(numero);

            
            int segundoDigito = (numero / 100) % 10; 
            int penultimoDigito = (numero / 10) % 10; 

           
            if (segundoDigito == penultimoDigito)
            {
                Console.WriteLine($"El segundo dígito ({segundoDigito}) es igual al penúltimo dígito ({penultimoDigito}).");
            }
            else
            {
                Console.WriteLine($"El segundo dígito ({segundoDigito}) no es igual al penúltimo dígito ({penultimoDigito}).");
            }
        }
        else
        {
            Console.WriteLine("El número ingresado no es de cuatro dígitos.");
        }
    }
}
