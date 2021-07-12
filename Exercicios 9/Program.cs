using System;

namespace Exercicios9
{
    class Program
    {
        static void Main(string[] args)
        {
            double real;
            double dolar = 1;

            Console.Write("Quanto de dinheiro que você tem? ");
            real = Convert.ToDouble(Console.ReadLine());

            
            dolar = real / 3.45;

            Console.WriteLine("Você pode comprar essa quantidade de dolar: " + dolar.ToString("F2"));
        }
    }
}
