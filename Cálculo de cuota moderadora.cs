using System;

namespace Cálculo_de_cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario actual: ");
            double sal = double.Parse(Console.ReadLine());

            int smmlv = 877803;

            if (sal < (smmlv * 2))
            {
                Console.WriteLine("A usted le corresponde la tarifa A. El valor de cuota moderadora para su cita es de $3400");
            }

            else if (smmlv * 2 <= sal && sal < smmlv * 5)
            {

                Console.WriteLine("A usted le corresponde la tarifa B. El valor de cuota moderadora para su cita es de $13500");
            }

            else
            {
                Console.WriteLine("A usted le corresponde la tarifa C. El valor de cuota moderadora para su cita es de $35600");
            }
        }
    }
}
