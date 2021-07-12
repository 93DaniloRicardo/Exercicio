using System;

namespace Exercicios35
{
    class Program
    {
        static void Main(string[] args)
        {
            int Carro;
            int Dias;
            int KM;
            double valorP1;
            double valorP2;
            double valorL1;
            double valorL2;
            Console.Write("Qual carro deseja pegar? (0) Carro Popular ou (1) Carro de Luxo? ");
            Carro = int.Parse(Console.ReadLine());
            
            Console.Write("Quantos dias você deseja alugar o carro? ");
            Dias = int.Parse(Console.ReadLine());

            Console.Write("Quantos KM percorrido? ");
            KM = int.Parse(Console.ReadLine());

            valorP1 = ((KM * 0.20) + (Dias * 90));
            valorP2 = ((KM * 0.10) + (Dias * 90));
            valorL1 = ((KM * 0.30) + (Dias * 150));
            valorL2 = ((KM * 0.25) + (Dias * 150));

            if(Carro == 0)
            {
                Console.WriteLine("Você pegou o carro Popular.");
                     if(KM < 100 )
                {
                    Console.WriteLine("valor total: " + valorP1);
                } 
                    else 
                {
                    Console.WriteLine("valor total: " + valorP2);
                }
            }
            else if (Carro == 1)
            {
                Console.WriteLine("Você pegou o carro de luxo.");
                    if (KM < 200 )
                {
                    Console.WriteLine("Valor total: " + valorL1);
                }
                    else
                {
                    Console.WriteLine("Valor Total: " + valorL2);
                }
            }
            else
            {
                Console.WriteLine("Erro, programa fechado!");
                Environment.Exit(0);
            }
            
            
            

        }
    }
}
