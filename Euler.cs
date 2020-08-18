using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            double resultado = 0;
            Console.Write("Ingrese el exponente x: ");
            double x = double.Parse(Console.ReadLine());

            static double Factorial(double valor)
            {
                if (valor <= 1) return 1;
                return valor * Factorial(valor - 1);
            }

            for (double i = 0; i <= n; i++)
            {
                resultado += (Math.Pow(x, i)) / Factorial(i);
            }

            Console.WriteLine("El resultado es: " + resultado);
        }

    }
}
