using System;
using System.ComponentModel.Design;

namespace Cálculo_de_deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario actual: ");
            double sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato (escriba 1 si es dependiente, 2 si es independiente): ");
            int tipCon = int.Parse(Console.ReadLine());

            int smmlv = 877803;


            if (tipCon == 1)
            { //(Si es dependiente)

                if (sal < smmlv)
                {
                    double baseCot = smmlv;

                    double pensi = baseCot * 0.04;
                    double eps = baseCot * 0.04;
                    double deduc = pensi + eps;

                    double salReal = sal - deduc;
                    Console.WriteLine("Su salario real es: " + salReal);

                    double salAnual = (salReal * 12) + sal;
                    Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                }

                else
                {
                    double baseCot = sal * 0.4; //La base de cotización es el 40% del salario

                    double pensi = baseCot * 0.04;
                    double eps = baseCot * 0.04;
                    double deduc = pensi + eps;

                    double salReal = sal - deduc;
                    Console.WriteLine("Su salario real es: " + salReal);

                    double salAnual = (salReal * 12) + sal;
                    Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                }

            }


            else if (tipCon == 2)
            { //(Si es independiente)

                Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo que le corresponde: ");
                double riesg = double.Parse(Console.ReadLine());

                if (riesg == 1)
                {
                    if (sal < smmlv)
                    {
                        double baseCot = smmlv;

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.00522;
                        double deduc = pensi + eps + arl;


                        double salReal = baseCot - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);

                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }

                    else
                    {
                        double baseCot = sal * 0.4; //La base de cotización es el 40% del salario

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.00522;
                        double deduc = pensi + eps + arl;


                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);

                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                                        
                }


                if (riesg == 2)
                {
                    if (sal < smmlv)
                    {
                        double baseCot = smmlv;

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.01044;
                        double deduc = pensi + eps + arl;


                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);

                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);

                    }

                    else
                    {
                        double baseCot = sal * 0.4; //La base de cotización es el 40% del salario

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.01044;
                        double deduc = pensi + eps + arl;


                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }

                }


                if (riesg == 3)
                {
                    if (sal < smmlv)
                    {
                        double baseCot = smmlv;

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.02436;
                        double deduc = pensi + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);

                    }

                    else
                    {
                        double baseCot = sal * 0.4; //La base de cotización es el 40% del salario

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.02436;
                        double deduc = pensi + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                }

                if (riesg == 4)
                {
                    if (sal < smmlv)
                    {
                        double baseCot = smmlv;

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.04350;
                        double deduc = pensi + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);

                    }

                    else
                    {
                        double baseCot = sal * 0.4; //La base de cotización es el 40% del salario

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.04350;
                        double deduc = pensi + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }

                }

                if (riesg == 5)
                {
                    if (sal < smmlv)
                    {
                        double baseCot = smmlv;

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.06960;
                        double deduc = pensi + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);

                    }

                    else
                    {
                        double baseCot = sal * 0.4; //La base de cotización es el 40% del salario

                        double pensi = baseCot * 0.16;
                        double eps = baseCot * 0.125;
                        double arl = baseCot * 0.06960;
                        double deduc = pensi + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);

                    }

                }

            }
        }
    }
}
