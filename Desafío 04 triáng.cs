using System;

namespace Desafío_04_triáng
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "w", "t" y "c"
            Console.WriteLine("Ingresa el valor de w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            //Teniendo la hipotenusa t y el ángulo c, hallamos los catetos "y" y "z" con razon. trigonom.
            double cRad = c * Math.PI / 180;
            double z = Math.Sin(cRad) * t; //Sale de sen c = z/t
            double y = Math.Cos(cRad) * t; //Sale de cos c = y/t

            //Para hallar x, hacemos Pitágoras con la hipotenusa w y el cateto z
            double n = Math.Sqrt((w * w) - (z * z));
            double x = n - y;

            Console.WriteLine("El valor de x es: " + Math.Round(x));
        }
    }
}
