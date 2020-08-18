using System;

namespace Sin_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            double resultado = 0;
            Console.Write("Ingrese el valor de x: ");
            double x = double.Parse(Console.ReadLine());

            static double Factorial(double valor)
            {
                if (valor <= 1) return 1;
                return valor * Factorial(valor - 1);
            }

            for (int i = 0; i < n; i++)
            {
                double denom = 2 * i + 1;
                resultado += Math.Pow(-1, i) / Factorial(denom) * Math.Pow(x, denom);

            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
