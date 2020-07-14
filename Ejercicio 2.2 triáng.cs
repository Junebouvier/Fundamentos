using System;

namespace Ejercicio_2._2_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los datos conocidos, o sea "t" y "a"
            Console.WriteLine("Ingresa el valor de t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            //Procedemos a convertir a radianes para realizar operaciones trigonométricas
            double aRad = a * (Math.PI / 180);

            double y = (t * (Math.Sin(aRad))); 

            Console.WriteLine("El valor de y es: " + y); //Sale de la afirmación sen a = y/t

            double z = (t * Math.Cos(aRad));
            Console.WriteLine("El valor de z es: " + z);

            //Ahora sólo falta encontrar el ángulo c
            double angRest = 90 + a;
            double c = (180 - angRest);
            Console.WriteLine("El valor de c es: " + c);

        }
    }
}
