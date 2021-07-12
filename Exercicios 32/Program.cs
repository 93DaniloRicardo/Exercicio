using System;

namespace Exercicios32
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jogador1;
            //int opcoes;

            Random numAleatorio = new Random();
            int Jogador2 = numAleatorio.Next(1,5);

            Console.Write("Escolha uma opção do 1 ao 5: ");
            Jogador1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Computador escolheu: " + Jogador2);

            if (Jogador1 == Jogador2)
            {
                Console.WriteLine("Jogador ganhou!");
            }
            else
            {
                Console.WriteLine("Computador Ganhou!");
            }
        }
    }
}
