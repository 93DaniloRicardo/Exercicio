using System;

namespace Exercicios25
{
    class Program
    {   
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;

            Console.WriteLine("Digite 3 lados do triangulo");

            Console.Write("Lado 1: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("lado 2: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("lado 3: ");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if((lado1<lado2+lado3) && (lado2<lado1+lado3) && (lado3<lado1+lado2))
            {
                Console.WriteLine("Forma um triangulo! ");
            }
            else
            {
                Console.WriteLine("Não formam um triangulo! ");
            }
        }
    }
}
