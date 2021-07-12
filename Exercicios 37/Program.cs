using System;

namespace Exercicios37
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos;
            int sexo;
            double salario;
            double Total1H;
            double Total2H;
            double Total3H;
            double Total1M;
            double Total2M;
            double Total3M;
            double Salario1M = 5.0  / 100.0;
            double Salario2M = 12.0 / 100.0;
            double Salario3M = 23.0 / 100.0;
            double Salario1H = 3.0  / 100.0;
            double Salario2H = 13.0 / 100.0;
            double Salario3H = 25.0 / 100.0;

            Console.Write("Digite o sexo do funcionário: (0) Homem e Mulher (1): ");
            sexo = int.Parse(Console.ReadLine());

            Console.Write("Digite o salario? ");
            salario = Convert.ToDouble(Console.ReadLine());
             
            Console.Write("Quantos anos o/a funcionário trabalha na empresa: ");
            anos = int.Parse(Console.ReadLine());

            Total1H = salario + (salario * Salario1H);
            Total2H = salario + (salario * Salario2H);
            Total3H = salario + (salario * Salario3H);

            Total1M = salario + (salario * Salario1M);
            Total2M = salario + (salario * Salario2M);
            Total3M = salario + (salario * Salario3M);
            
            if(sexo == 0 )
            {
                Console.WriteLine("Você digitou Homem ");
                    if(anos <= 19)
                {
                        Console.WriteLine("Salario aumentou para: " + Total1H);
                }
                    else if (anos >= 20 && anos <= 29)
                {
                        Console.WriteLine("Salario aumentou para: " + Total2H);
                }
                    else 
                {
                        Console.WriteLine("Salario aumentou para: " + Total3H);
                }
                

            }else if (sexo == 1)
            {
                Console.WriteLine("Você digitou Mulher ");
                    if(anos <=14 )
                {
                        Console.WriteLine("Salario aumenta para: " + Total1M);
                } 
                    else if (anos >= 15 && anos <= 20)
                {
                        Console.WriteLine("Salario aumentou para: " + Total2M);
                }
                    else
                {
                        Console.WriteLine("Salario aumentou para: " + Total3M);
                }


            }else
            {
                Console.WriteLine("Error");
                Environment.Exit(2);
            }
            
        }
    }
}
