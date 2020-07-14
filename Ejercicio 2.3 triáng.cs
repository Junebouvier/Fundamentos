using System;

namespace Ejercicio_2._3_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "c" y "z"
            Console.WriteLine("Ingresa el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de z: ");
            double z = double.Parse(Console.ReadLine());

            //Convertimos el ángulo c a radianes para hacer operaciones trigonométricas
            double cRad = c * Math.PI / 180;

            double t = z / Math.Sin(cRad); //Sale de la afirmación sen c = z/t

            Console.WriteLine("El valor de t es: " + t);

            //Ahora hallamos el cateto y con Pitágoras
            double y = Math.Sqrt((t * t) - (z * z));
            Console.WriteLine("El valor de y es: " + y);

            //Hallamos el ángulo a
            double angRest = 90 + c;
            double a = 180 - angRest;
            Console.WriteLine("El valor de a es: " + a);

            
        }
    }
}
