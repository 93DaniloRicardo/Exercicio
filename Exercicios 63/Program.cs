using System;

namespace Exercicios_63
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int soma = 0;
            double MediaValores = 0;
            double MediaTotal = 0;
            double nota = 0;
            int MenorValor = 0;
            int ValorPares = 0;
            string S;

            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());
            MenorValor = valor;

            do
            {
                if(valor%2 <= ValorPares)
                {
                    ValorPares = ValorPares + 1;
                }
                if(valor < MenorValor )
                {
                    MenorValor = valor;
                }

                soma = (soma + valor);
                MediaValores = (MediaValores + nota);
                
                Console.Write("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());

                Console.Write("Você deseja continuar? s/n ");
                S = Console.ReadLine();
            } while (S == "s");

            //a) O somatório entre todos os valores
            Console.WriteLine("Valor Total: " + soma);
            //b) Qual foi o menor valor digitado
            Console.WriteLine("O menor valor digitado: " + MenorValor);
            //c) A média entre todos os valores
            Console.WriteLine("Média final: " + (MediaTotal = MediaValores / valor) );
            //d) Quantos valores são pares
            Console.WriteLine("Quantas vezes valores pares foram digitados: " + ValorPares);
        }
    }
}
