using System;

namespace Exercicios13
{
    class Program
    {
        static void Main(string[] args)
        {
             double acressimo = 15.0 / 100.0;
            double salario;
            double ValorFinal;
            Console.Write("digite salario: ");
            salario = double.Parse(Console.ReadLine());
            
            ValorFinal = salario + (acressimo * salario);

            Console.WriteLine("Valor total com acressimo é: " + ValorFinal);
        }
    }
}
