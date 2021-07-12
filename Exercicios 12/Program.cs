using System;

namespace Exercicios12
{
    class Program
    {
        static void Main(string[] args)
        { 
            double desconto = 5.0 / 100.0;
            double produto;
            double ValorFinal;
            Console.Write("digite o valor do produto: ");
            produto = double.Parse(Console.ReadLine());

            
            ValorFinal = produto - (desconto * produto);

            Console.WriteLine("Valor total com desconto é: " + ValorFinal);
        }
    }
}
