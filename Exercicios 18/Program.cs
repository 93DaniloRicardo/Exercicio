using System;

namespace Exercicios18
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.Write("Quantos anos que a pessoa tem? ");
            ano = int.Parse(Console.ReadLine());

            if(ano <= 17) 
            {
                Console.WriteLine("Não pode votar!");
            }
            else 
            {
                Console.WriteLine("Pode Votar!");
            }
        }
    }
}
