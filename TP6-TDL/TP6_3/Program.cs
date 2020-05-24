using System;

namespace TP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            decimal num;

            Console.WriteLine("Ingrese un numero entero\n");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un numero decimal\n");
            num = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(num1));
            Console.WriteLine("Cuadrado: " + Math.Pow(num1, 2));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num1));
            Console.WriteLine("Seno: " + Math.Sin(num1));
            Console.WriteLine("Coseno: " + Math.Cos(num1));
            Console.WriteLine("Parte entera: " + Math.Truncate(num));

            Console.WriteLine("Ingrese 2 numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El maximo es: " + Math.Max(num1, num2));
            Console.WriteLine("El minimo es: " + Math.Min(num1, num2));
        }
    }
}
