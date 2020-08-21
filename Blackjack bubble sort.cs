using System;
using System.Xml;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = carta1 + carta2, turn = 0;
            string continuar;
            

            Console.Write("Ingrese el número de jugadores (mín 2, máx 5) ");
            int n = int.Parse(Console.ReadLine());
            int numerojug = n;
            string[] nombres = new string[n];
            int[] puntajes = new int[n];

            while (n < 2 || n > 5)
            {
                Console.Write("Error. Mínimo 2 jugadores, máximo 5. Intente de nuevo ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0;  n != 0; i++)
            {
                n -= 1;
                turn++;
                Console.WriteLine("Turno #" + turn);
                Console.WriteLine("Ingrese su nombre");
                string playername = Console.ReadLine();
                nombres[i] = playername;
                
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;
                Console.WriteLine("Su 1ra carta tiene el valor de " + carta1);
                Console.WriteLine("Su 2da carta tiene el valor de " + carta2);
                Console.WriteLine("Su total es de " + total);
                Console.WriteLine("¿Desea continuar (pedir una carta adicional)? (s/n): ");
                continuar = (Console.ReadLine());

                while (continuar != "n" && continuar != "s")
                {
                    Console.WriteLine("Respuesta no válida, debe responder con s o n. Inténtelo de nuevo");
                    continuar = (Console.ReadLine());
                }

                while (continuar == "s")
                {
                    int cartaAdc = aleatorio.Next(1, 11);
                    total += cartaAdc;
                    Console.WriteLine("Su nueva carta tiene el valor de " + cartaAdc);
                    Console.WriteLine("Su nuevo total es de " + total);

                    if (total < 21)
                    {
                        Console.WriteLine("¿Desea continuar? (s/n): ");
                        continuar = (Console.ReadLine());
                        while (continuar != "n" && continuar != "s")
                        {
                            Console.WriteLine("Respuesta no válida, debe responder con s o n. Inténtelo de nuevo");
                            continuar = (Console.ReadLine());
                        }
                    }

                    else if (total == 21)
                    {
                        Console.WriteLine("Felicitaciones, ha ganado el juego");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Usted ha sido eliminado");
                        total = 0;
                        break;
                    }
        
                }

                Console.WriteLine("Su total final fue: " + total);
                puntajes[i] = total;

                
            }

            for (int j = 0; j < numerojug; j++)
            {
                for (int i = 0; i < numerojug - 1; i++)
                {
                    if (puntajes[i] > puntajes[i + 1])
                    {
                        int tmp = puntajes[i];
                        string tmp2 = nombres[i];
                        puntajes[i] = puntajes[i + 1];
                        nombres[i] = nombres[i + 1];
                        puntajes[i + 1] = tmp;
                        nombres[i + 1] = tmp2;

                    }

                }

            }


            Console.WriteLine("Ya no hay más turnos");

            if (puntajes[numerojug - 1] == 0) Console.WriteLine("No hay ningún ganador");
            else
            {
                Console.WriteLine("El ganador fue " + nombres[numerojug - 1] + " con " + puntajes[numerojug - 1] + " puntos");
                Console.WriteLine("El segundo lugar fue " + nombres[numerojug - 2] + " con " + puntajes[numerojug - 2] + " puntos");
            }
        }

    }
}
