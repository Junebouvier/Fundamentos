using System;

namespace Fórmula_cuadrática
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingresa el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double discrim = ((b * b) - 4 * a * c);
            
            

            if (discrim == 0)
            {
                double discrimCero = -b / (a * 2);
                Console.WriteLine("Hay solución y es única: " + discrimCero);
            }

            else if (discrim > 0)
            {
                double formuCua = (-b + Math.Sqrt(discrim)) / (a * 2);
                double formuNeg = (-b - Math.Sqrt(discrim)) / (a * 2);
                Console.WriteLine("Hay dos soluciones. X1: " + formuCua);
                Console.WriteLine("X2: " + formuNeg);
            }

            else
            {
                Console.WriteLine("No hay una posible solución.");
            }


        }
    }
}
