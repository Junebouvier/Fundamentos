using System;

namespace Cálculo_de_tarifa
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
                Console.WriteLine("A usted le corresponde la tarifa A");
            }

            else if (smmlv * 2 <= sal && sal < smmlv * 4) {

                Console.WriteLine("A usted le corresponde la tarifa B");
            }

            else
            {
                Console.WriteLine("A usted le corresponde la tarifa C");
            }
        }
    }
}
