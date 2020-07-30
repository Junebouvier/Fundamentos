using System;
using System.Xml;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0;
            string continuar = "";

            carta1 = aleatorio.Next(1, 11);
            carta2 = aleatorio.Next(1, 11);
            int sumCarta = carta1 + carta2;
            Console.WriteLine("Su 1ra carta tiene el valor de " + carta1);
            Console.WriteLine("Su 2da carta tiene el valor de " + carta2);
            Console.WriteLine("Su total es de " + sumCarta);
            Console.WriteLine("¿Desea continuar (pedir una carta adicional)? (s/n): " + continuar);
            continuar = (Console.ReadLine());

            while (continuar == "s")
            {
                int cartaAdc = aleatorio.Next(1, 11);
                int nuevaSum = sumCarta + cartaAdc;

                if (nuevaSum < 21)
                {
                    sumCarta += cartaAdc;
                    Console.WriteLine("Su nueva carta tiene el valor de " + cartaAdc);
                    Console.WriteLine("Su nuevo total es de " + sumCarta);
                    continuar = "";
                    Console.WriteLine("¿Desea continuar? (s/n): " + continuar);
                    continuar = (Console.ReadLine());
                    
                }
                
                else if (nuevaSum == 21)
                {
                    sumCarta += cartaAdc;
                    Console.WriteLine("Su nueva carta tiene el valor de " + cartaAdc);
                    Console.WriteLine("Su nuevo total es de " + sumCarta);
                    Console.WriteLine("Felicitaciones, ha ganado el juego");
                    continuar = "n";
                    
                }

                else
                {
                    sumCarta += cartaAdc;
                    Console.WriteLine("Su nueva carta tiene el valor de " + cartaAdc);
                    Console.WriteLine("Su nuevo total es de " + sumCarta);
                    Console.WriteLine("Usted ha sido eliminado");
                    continuar = "n";
                   
                }
            }

            Console.WriteLine("Su total final fue: " + sumCarta);
        }
    }
}
