using System;

namespace Exercicios28
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprimento;
            double largura;
            double total;

            Console.Write("Qual o Comprimento? ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual a largura? ");
            largura = Convert.ToDouble(Console.ReadLine());

            total = comprimento * largura;

            Console.WriteLine("Total: " + total);

            if (total < 99)
            {
                Console.WriteLine("Terreno Popular");
            }
            else if (total >= 100 && total < 499)
            {
                Console.WriteLine("Terreno Master");
            }
            else 
            {
                Console.WriteLine("Terreno VIP");
            }
        }
    }
}
