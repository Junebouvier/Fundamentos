using System;

namespace Matriz_ingresar_X
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", " "};
            int filas = 10, colum = 15;

            string[,] tablero = new string[filas, colum];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                }
            }

            Console.WriteLine("Matriz inicial: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.WriteLine("|");
            }

            Console.WriteLine("Seleccione una casilla en la que desee ingresar una X");
            Console.Write("Fila: ");
            int fil = int.Parse(Console.ReadLine());
            Console.Write("Columna: ");
            int col = int.Parse(Console.ReadLine());

            while (tablero[fil, col] != " ")
            {
                Console.WriteLine("La posición seleccionada ({0},{1}) se encuentra ocupada", fil, col);
                Console.WriteLine("Debe seleccionar otra posición");
                Console.Write("Fila: ");
                fil = int.Parse(Console.ReadLine());
                Console.Write("Columna: ");
                col = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Asignación aceptada");
            tablero[fil, col] = "X";

            Console.WriteLine("Matriz modificada: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.WriteLine("|");
            }
        }
    }
}
