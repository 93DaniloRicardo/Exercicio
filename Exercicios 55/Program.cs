using System;

namespace Exercicios55
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jogador1;
            int Inicio = 0;
            int Fim = 5;
            int Vidas = 5;
            int acertos;
            //int opcoes;

            Random numAleatorio = new Random();
            int Jogador2 = numAleatorio.Next(1,5);

            Console.Write("Escolha uma opção do 1 ao 5: ");
            Jogador1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Computador escolheu: " + Jogador2);

            while(Inicio < Fim)
            {
                if( acertos == 0)
                {
                    Vidas = Vidas - 1;
                            if(Vidas == 0)
                        {
                            Console.WriteLine("Você perdeu! Numero sorteado era: " + Jogador2 );
                        }
                            else
                        {
                            Console.WriteLine("Você errou seu noob! próxima tentativa!" + Vidas);
                        }
                }
                    else
                {
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
    }
}
