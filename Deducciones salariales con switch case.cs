using System;
using System.ComponentModel.Design;

namespace Cálc_deduc_salariales_con_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario actual: ");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato (1 = Independiente // 2 = Dependiente): ");
            int tipoCon = int.Parse(Console.ReadLine());

            double arl = 0, pensi = 0, eps = 0; //Datos para los cálculos luego
            int bonific = 0, smmlv = 877803; //Datos para los cálculos luego

            double baseCot = salario * 0.4;
            if (baseCot < smmlv) baseCot = smmlv;

            switch(tipoCon)
            {
                case 1: //Si es independiente
                    Console.WriteLine("Ingrese un número de 1 a 5 que corresponda a su clase de riesgo: ");
                    int riesg = int.Parse(Console.ReadLine());

                    switch (riesg)
                    {
                        case 1: arl = baseCot * 0.00522; break;
                        case 2: arl = baseCot * 0.01044; break;
                        case 3: arl = baseCot * 0.02436; break;
                        case 4: arl = baseCot * 0.04350; break;
                        case 5: arl = baseCot * 0.06960; break;
                        default: Console.WriteLine("No es un número válido."); break;
                    }

                    pensi = baseCot * 0.16;
                    eps = baseCot * 0.125; break;
                  
                case 2: //Si es dependiente
                    pensi = baseCot * 0.04;
                    eps = baseCot * 0.04;

                    bonific = salario; break;


                default: Console.WriteLine("No es un número válido."); break;
                    
            }

            int salReal = salario - (int)(pensi + eps + arl);
            int salAnual = salReal * 12 + bonific;

            Console.WriteLine("Pensión: " + pensi + ". EPS: " + eps + ". ARL: " + arl);
            Console.WriteLine("Salario real: " + salReal + " / Salario anual: " + salAnual);

        }
    }
}



