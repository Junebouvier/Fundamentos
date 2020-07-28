using System;

namespace Desafío_valores_extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int i = 0, max = 0, min = 0;
            string maxname = "", minname = "";
            Console.Write("Ingrese la cantidad de datos (n):   ");
            int n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Nombre: ");
                string name = (Console.ReadLine());

                if (i == 0)
                {
                    max = edad;
                    min = edad;
                    maxname = name;
                    minname = name;
                }
                if (edad > max)
                {
                    max = edad;
                    maxname = name;

                }
                if (edad < min)
                {
                    min = edad;
                    minname = name;
                }

                total += edad;
                i++;

            }
            double promedio = total / n;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("El mayor es " + maxname + " con la edad de " + max + " años");
            Console.WriteLine("El menor es " + minname + " con la edad de " + min + " años");
        }
    }
}
