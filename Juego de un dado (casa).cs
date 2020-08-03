using Microsoft.VisualBasic.FileIO;
using System;
using System.Xml.Schema;

namespace Juego_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego");
            Random aleatorio = new Random();
            int dado = 0, total = 0, i = 0, dadoAnte = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                dadoAnte = dado;
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                Console.WriteLine("Total: " + total);
                i++;

                if (i < 4)
                {
                    if (dadoAnte == 10 && dado == 12)
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

                if (i >= 4)
                {
                    if (dado % 2 != 0)
                    {
                        total = 0;
                        Console.WriteLine("Usted ha sido eliminado");
                        break;
                    }

                    else if (total >= 100 || (dadoAnte == 10 && dado == 12))
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

            }

            Console.WriteLine("Su total fue: " + total + " puntos. Gracias por participar.");
        }
    }
}
