using System;

namespace Ejercicio_2._1_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "y" y "z"
            Console.WriteLine("Ingresa el valor de y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de z: ");
            double z = double.Parse(Console.ReadLine());

            //Debemos hallar la hipotenusa "t" con Pitágoras
            double t = Math.Sqrt((y * y) + (z * z));
            Console.WriteLine("La hipotenusa t es: " + t);

            //Ahora, para hallar los ángulos, usamos las razones trigonométricas y pasamos a grados
            double c = Math.Asin(z / t);
            double cGrad = (c * 180) / Math.PI;

            Console.WriteLine("El ángulo c es: " + cGrad);

            //Teniendo el ángulo c, sólo queda hallar el ángulo a, por medio de una resta
            double sumAng = 90 + cGrad;
            double a = 180 - sumAng;

            Console.WriteLine("El ángulo a es: " + a);
        }
    }
}
