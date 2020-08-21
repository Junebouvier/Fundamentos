using System;

namespace Ordenamiento_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Tanjiro", "Nezuko", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };

            for (int j = 0; j < estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura [i + 1])
                    {
                        double tmp = estatura[i];
                        string ntemp = nombres[i];
                        estatura[i] = estatura[i + 1];
                        nombres[i] = nombres[i + 1];
                        estatura[i + 1] = tmp;
                        nombres[i + 1] = ntemp;
                        
                    }

                }
            
            }

            for (int i = 0; i < estatura.Length; i++)
            {
               Console.WriteLine(nombres[i] + " " + estatura[i]);
            }
        }
    }
}
