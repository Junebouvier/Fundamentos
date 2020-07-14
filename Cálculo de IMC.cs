using System;

namespace Cálculo_de_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ingrese su estatura en metros: ");
           double m = double.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese su peso en kilogramos: ");
           double kg = double.Parse(Console.ReadLine());

            double imc = kg / (m * m);

            if (imc < 18.5)
            {
                Console.WriteLine("Su IMC es: " + imc + "Usted se encuentra bajo el peso ideal.");

            }

            else if (18.5 <= imc && imc < 24.9) 
            {
                Console.WriteLine("Su IMC es: " + imc + ". Usted se encuentra en el peso ideal.");

            }

            else if (imc > 30)
            {
                Console.WriteLine("Su IMC es: " + imc + "Usted se encuentra con sobrepeso.");

            }

            else
            {
                Console.WriteLine("Su IMC es: " + imc + "Usted se encuentra con obesidad.");

            }





        }
    }
}
