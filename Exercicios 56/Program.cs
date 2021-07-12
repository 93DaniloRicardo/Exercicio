using System;

namespace Exercicios56
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inicio = 0;
            int Soma;
            int SomaFinal = 0;
            int SomaFinal2 = 0;

            Console.Write("Digite os valores: ");
            Soma = int.Parse(Console.ReadLine());

            while (Inicio < Soma)
            {
                SomaFinal = Soma;
                SomaFinal2 = SomaFinal2 + SomaFinal;

                Console.Write("Digite os valores: ");
                Soma = int.Parse(Console.ReadLine());
                
                

                Inicio++;

            }
            Console.WriteLine("Valor total: " + SomaFinal2);
        }
    }
}
