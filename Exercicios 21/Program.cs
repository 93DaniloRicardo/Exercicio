using System;

namespace Exercicios21
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            bool bissesto;
            Console.Write("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());
            
                if ((ano % 400 == 0) && (ano % 100 != 0))
            {
                Console.WriteLine("Ano é bissesto!");
            }
                else 
            {
                Console.WriteLine("Não é bissesto!");
            }
            
        }
    }
}
