using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        // Diferencia
        int diferencia = Math.Abs(num1 - num2);

       
        if (diferencia <= 10)
        {
           
            int menor = Math.Min(num1, num2);
            int mayor = Math.Max(num1, num2);

         
            Console.WriteLine($"Los números comprendidos entre {menor} y {mayor} son:");
            for (int i = menor; i <= mayor; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("La diferencia entre los dos números es mayor a 10.");
        }
    }
}
