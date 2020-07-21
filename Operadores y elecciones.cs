using System;

namespace Operadores_y_elecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de votos por el partido 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos por el partido 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa número total de la población de todas las edades: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa  el porcentaje (de 0 a 100%) de la población que es mayor de edad: ");
            double p = double.Parse(Console.ReadLine());

            int abs = (int)(n * p/100) - (a + b + blancos + anulados);
            int numVot = a + b + blancos + anulados;

            bool cond1 = anulados < (a + b) * 0.3;
            bool cond2 = (a + b) > blancos;
            bool cond3 = abs < numVot;

            if ((cond1||cond2) && cond3)
            {
                Console.WriteLine("Las votaciones fueron exitosas");

                if (a > b) {
                    Console.WriteLine("El partido 1 es el ganador");
                }
                else
                {
                    Console.WriteLine("El partido 2 es el ganador");
                }

            }

            else
            {
                Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
            }

        }
    }
}
