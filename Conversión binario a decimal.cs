using System;

namespace Conversión_binario_a_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresamos los 5 dígitos en binario (unos o ceros)

           Console.WriteLine("Digite el primer dígito: ");
            int b0 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo dígito: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer dígito: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el cuarto dígito: ");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el quinto dígito: ");
            int b4 = int.Parse(Console.ReadLine());


            //Hacemos la conversión de binario a decimal

            int d0 = (b0 * 16);
            int d1 = (b1 * 8);
            int d2 = (b2 * 4);
            int d3 = (b3 * 2);
            int d4 = (b4 * 1);

            //Mostrar el resultado (decimal) en pantalla
            int sumdec = (d0 + d1 + d2 + d3 + d4);
            Console.WriteLine("El resultado en decimal es: " + sumdec);
        }
    }
}
