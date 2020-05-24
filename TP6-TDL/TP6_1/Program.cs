using System;

namespace TP6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto;
            Console.WriteLine("Ingrese un numero\n");
            num = int.Parse(Console.ReadLine());
            //Console.WriteLine("numero: " + num);
            if(num <= 0)
            {
                Console.WriteLine("No se puede invertir el número\n");
            }
            else
            {
                while (num > 0)
                {
                    resto = num % 10;
                    Console.WriteLine("" + resto);
                    num = num / 10;
                }
            }
            
        }
    }
}
