using System;
using System.Numerics;

namespace Desafío_01_triáng
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "b", "y" y "z"
            Console.WriteLine("Ingresa el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de z: ");
            double z = double.Parse(Console.ReadLine());

            //Para hallar "a", usamos razones trigonométricas y pasamos a grados

            double a = Math.Atan(y / z); //Sale de tan a = y/z
            double aGrad = (a * 180) / Math.PI;

            double k = aGrad + b; //Sumamos los ángulos "a" y "b" para obtener el del triángulo mayor
            double kRad = (k * Math.PI) / 180;

            //Le asignamos "q" al cateto del triángulo grande, que despejamos con razones trigonométricas

            double q = Math.Tan(kRad) * z; //Sale de tan k = q/z
           
            double x = q - y;
            Console.WriteLine("El valor de x es: " + Math.Round(x));


            //Hallamos ángulo "e"

        }
    }
}
