using System;

namespace Exercicios17
{
    class Program
    {
        static void Main(string[] args)
        {
            int multa = 5;
            int velocidade;

            Console.Write("Qual a velocidade? ");
            velocidade = int.Parse(Console.ReadLine());

            if (velocidade <= 80)
            {
                Console.WriteLine("Não recebeu multa! ");
            }
            else
            {
                Console.WriteLine("Recebeu Multa! valor de: " + (velocidade - 80) * 5);
               
            }   
                 
        }
    }
}
