using System;

namespace Exercicios_66
{
    class Program
    {
        static void Main(string[] args)
        {
            string sair = "s";
            int valor1;   
            int valor2 = 0;
            int resultado;

            Console.Write("Digite 1 valor: ");
            valor1 = int.Parse(Console.ReadLine());

            do
            {
                if (valor2 <= 5)
                {
                    
                    resultado = valor1 * valor2;
                    Console.WriteLine(valor1 + " x " + valor2 + " = " + resultado);
                    valor2++;
                }
                else if (valor2 >= 10)
                {
                    resultado = valor1 * valor2;
                    Console.WriteLine(valor1 + " x " + valor2 + " = " + resultado);
                    valor2++;
                    
                    Console.Write("Digite 's' para continuar: ");
                    sair = Console.ReadLine();

                }
                    

            } while (sair == "s");
        }
    }
}
