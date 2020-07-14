using System;

namespace Desafío_02_triáng
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "d", "b" y "y"
            Console.WriteLine("Ingresa el valor de d: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de y: ");
            double y = double.Parse(Console.ReadLine());

            //Hallamos ángulo "e" y luego el "c"
            double e = 180 - (b + d);
            double c = 180 - e;

            //Teniendo el ángulo c y el cateto y, sólo queda hacer razon. trigon. para hallar z
            double cRad = (c * Math.PI) / 180;
            double z = Math.Tan(cRad) * y;  //Sale de tan c = z/y

            Console.WriteLine("El valor de z es: " + Math.Round(z));

        }
    }
}
