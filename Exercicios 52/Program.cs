using System;

namespace Exercicios52
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inicio = 0;
            int Final = 9;
            int Pessoas;
            int MaiorIdade = 0;
            int MenorIdade;
            int contadorMaiorIdade = 0, contadorMenorIdade = 0;
           // double Média;


            Console.Write("Digite 10 idade das pessoas: ");
            Pessoas = int.Parse(Console.ReadLine());
            MenorIdade = Pessoas;

            while(Inicio < Final)
            {

                if(Pessoas > MaiorIdade)
                {
                    MaiorIdade = Pessoas;
                }
                if(Pessoas < MenorIdade)
                {
                    MenorIdade = Pessoas;
                }
                if(Pessoas > 18)
                {
                    contadorMaiorIdade = contadorMaiorIdade + 1;
                }
                if (Pessoas < 8)
                {
                    contadorMenorIdade = contadorMenorIdade + 1;
                }
                Console.Write("Digite 10 idade das pessoas: ");
                Pessoas = int.Parse(Console.ReadLine());
                Inicio++;
            }
            Console.WriteLine("A Maior Idade é: " + MaiorIdade);
            Console.WriteLine("A Quantidade de maior de idade é: " + contadorMaiorIdade);
            Console.WriteLine("A Quantidade de menor que 8 anos é: " + contadorMenorIdade);
            Console.WriteLine("A média de idade é: " + (Pessoas = Pessoas / 10));
        }
    }
}
