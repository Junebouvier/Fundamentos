using System;

namespace Matrices_X_y_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int filas = 10, colum = 15, contadXs = 0, contadOs = 0;
            
            string[,] tablero = new string[filas, colum];
            string[,] salida = new string[filas, colum];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    if (tablero [i, j] == "X") contadXs++;
                    if (tablero[i, j] == "O") contadOs++;
                    salida[i, j] = "-";
                }
            }
            
            //Visualización entrada
            Console.WriteLine("Entrada: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.WriteLine("|");
            }

            //Proceso
            for (int i = 0; i < tablero.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {
                    if (tablero[i,j] == "X")
                    {
                        
                        if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == tablero[i, j + 2])
                        {
                            salida[i, j] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }

                        if (tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                        {
                            salida[i, j] = "1";
                            salida[i + 1, j] = "1";
                            salida[i + 2, j] = "1";
                        }
                    }

                    if (tablero[i, j] == "O")
                    {
                        
                        if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == tablero[i, j + 2])
                        {
                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }

                        if (tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                        {
                            salida[i, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                    }
                }
            }

            int totaldatos = filas * colum;
            int porcentXs = (contadXs * 100) / totaldatos;
            int porcentOs = (contadOs * 100) / totaldatos;
            Console.WriteLine("El porcentaje de Xs es {0}% y el porcentaje de Os es {1}%", porcentXs, porcentOs);
            Console.WriteLine(" ");
            //Visualización salida
            Console.WriteLine("Salida: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("|");
        }
    }
}
