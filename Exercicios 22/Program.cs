using System;

namespace Exercicios22
{
    class Program
    {
        static void Main(string[] args)
        {   int ano;
            int militar;
            Console.Write("Quantos anos tem: ");
            ano = int.Parse(Console.ReadLine());

            if (ano <= 17)
            {
                Console.WriteLine("Não pode alistar");
            }
            else
            {   
                
                Console.WriteLine("Pode alistar");
            }
                   
        
        }
    }
}
