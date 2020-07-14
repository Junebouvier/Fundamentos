using System;

namespace Desafío_03_triáng
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "w", "d" y "x"
            Console.WriteLine("Ingresa el valor de w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de d: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de x: ");
            double x = double.Parse(Console.ReadLine());

            //Hallamos el cateto z con razones trigonométricas
            double dRad = d * Math.PI / 180;
            double z = Math.Sin(dRad) * w; //Sale de sen d = z/w

            //Hacemos Pitágoras con el cateto z y la hipotenusa w
            double n = Math.Sqrt((w * w) - (z * z));
            double y = n - x;

            Console.WriteLine("El valor de y es: " + Math.Round(y));
        }
    }
}
