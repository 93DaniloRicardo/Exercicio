using System;

namespace Exercicios10
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double altura;
            double tinta;
            double area;

            Console.Write("Quantos de Largura? ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantos de Altura? ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = altura * largura;

            Console.WriteLine("Area quadrada é: " + area);

            tinta = area / 2;

            Console.WriteLine("Quantidade de tinta que precisa é: "+ tinta.ToString("F2"));

            Console.WriteLine("Cada 2 metros quadrado é 1 litro de tinta\n\n\n");

               
        }
    }
}
