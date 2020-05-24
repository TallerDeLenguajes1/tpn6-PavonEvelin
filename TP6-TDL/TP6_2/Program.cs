using System;

namespace TP6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opcion, respuesta=1;
            do
            {
                Console.WriteLine("1-Suma\n");
                Console.WriteLine("2-Resta\n");
                Console.WriteLine("3-Producto\n");
                Console.WriteLine("4-Cociente\n");
                Console.WriteLine("Ingrese una opcion\n\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        Console.WriteLine("Ingrese dos numeros\n");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es:\n" + (num1 + num2));
                        Console.WriteLine("¿Desea realizar otra operacion? (1 si, 0 no)\n");
                        respuesta = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Ingrese dos numeros\n");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La resta es:\n" + (num1 - num2));
                        Console.WriteLine("¿Desea realizar otra operacion? (1 si, 0 no)\n");
                        respuesta = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Ingrese dos numeros\n");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El producto es:\n" + (num1 * num2));
                        Console.WriteLine("¿Desea realizar otra operacion? (1 si, 0 no)\n");
                        respuesta = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Ingrese dos numeros\n");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El cociente es:\n" + (num1 / num2));
                        Console.WriteLine("¿Desea realizar otra operacion? (1 si, 0 no)\n");
                        respuesta = int.Parse(Console.ReadLine());
                        break;
                }
            } while(respuesta != 0);
        }
    }
}
