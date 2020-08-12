using System;
using System.Net.Sockets;

namespace Juego_de_dos_dados__clase_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego");
            Random aleatorio = new Random();
            int dado = 0, totalAcum = 0, consec = 0, lives = 2, contadorEsp = 2, contadUnos = 0;


            string continuar = "s";

            while (continuar == "s")
            {   
                if (contadorEsp > 0)
                {
                    Console.WriteLine("¿Desea tirar un dado especial? (s/n)");
                    string continuarEsp = Console.ReadLine().ToUpper();

                    if (continuarEsp == "S")
                    {
                        contadorEsp -= 1;
                        dado = aleatorio.Next(1, 13);
                        Console.WriteLine("Dado: " + dado);

                    }

                    else if (continuarEsp == "N")
                    {
                        dado = aleatorio.Next(1, 7);
                        Console.WriteLine("Dado: " + dado);
                    }
                }
                
                else if (contadorEsp == 0)
                {
                    dado = aleatorio.Next(6, 6);
                    Console.WriteLine("Dado: " + dado);
                }

                totalAcum += dado;
                Console.WriteLine("Total: " + totalAcum);
               

                if (dado == 6) consec++;

                else consec = 0;

                if (consec == 2)
                {
                  
                    if (lives < 3)
                    {
                        lives++;
                        Console.WriteLine("¡Ha recuperado una vida! Ahora tiene " + lives);
                    }

                    else if (lives == 3) Console.WriteLine("Sacaste los 6s dobles pero ya no puedes acumular más vidas");
                    consec = 0;
                }

                if (dado == 1)
                {
                    contadUnos++;

                    if (contadUnos ==2)
                    {
                        if (lives > 0)
                        {
                            lives -= 1;

                            if (lives == 0)
                            {
                                totalAcum = 0;
                                Console.WriteLine("Usted ha sido eliminado");
                                break;
                            }
                            else
                            {   
                                totalAcum -= 10;
                                if (totalAcum < 0) totalAcum = 0;
                                Console.WriteLine("¡Ha perdido una vida! Ahora tiene " + lives + " y su nuevo total es " + totalAcum);
                                
                            }
                        }
                        contadUnos = 0;
                    }
                    
                }

                if (totalAcum >= 100)
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
           
        }
    
    }
}
