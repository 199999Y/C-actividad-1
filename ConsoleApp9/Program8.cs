using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero de cinco dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        
        if (numero >= 10000 && numero <= 99999 || numero <= -10000 && numero >= -99999)
        {
            //valor absoluto
            numero = Math.Abs(numero);

            
            int unidad = numero % 10;              
            int decena = (numero / 10) % 10;       
            int millar = (numero / 1000) % 10;    
            int decenaMillar = (numero / 10000);   

            //capicúa
            if (unidad == decenaMillar && decena == millar)
            {
                Console.WriteLine($"El número {numero} es capicúa.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es capicúa.");
            }
        }
        else
        {
            Console.WriteLine("El número ingresado no es de cinco dígitos.");
        }
    }
}
  