using System;

namespace Juego_de_dos_dados__clase_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego");
            Random aleatorio = new Random();
            int dado = 0, dado2 = 0, total = 0, totalAcum = 0, i = 0, turn = 0, consec = 0;
            
            string continuar = "s";

            while (continuar == "s")
            {
                
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + dado);
                dado2 = aleatorio.Next(1, 13);
                Console.WriteLine("Segundo dado: " + dado2);
                total = dado + dado2;
                totalAcum += dado + dado2;
                Console.WriteLine("Total: " + totalAcum);
                i++;

                if (dado == dado2) consec++;

                else consec = 0;

                if (consec == 3)
                {
                   Console.WriteLine("Felicitaciones, ha ganado el juego");
                    break;
                }
                
                if (total > 6) turn++;

                if (dado == 1 && dado2 == 1)
                {
                    totalAcum = 0;
                    Console.WriteLine("Usted ha sido eliminado");
                    break;
                }

                else if (totalAcum >= 100)
                {
                    Console.WriteLine("Felicitaciones, ha ganado el juego");
                    break;
                }

                else
                {
                    Console.WriteLine("¿Desea continuar? (s/n): ");
                    continuar = (Console.ReadLine());
                }

            }

            Console.WriteLine("Su total fue: " + totalAcum + " puntos. Gracias por participar.");
            Console.WriteLine("Porcentaje de turnos donde la suma de los dados fue superior a 6: " + turn * 100 / i + "%");

        }
    
    }
}

