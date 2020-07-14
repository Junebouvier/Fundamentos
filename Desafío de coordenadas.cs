using System;

namespace Desafío_04_triáng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese X1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese X2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double m = (y2 - y1) / (x2 - x1);
            Console.WriteLine("La pendiente es: " + m);

            double b = y1 - (m * x1);
            Console.WriteLine("El intercepto es: " + b);

            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("La distancia es: " + d);
        }
    }
}


