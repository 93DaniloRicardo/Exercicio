using System;

namespace Exercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int sucessor;
            int antecessor;
            
            Console.Write("Digite o valor: ");
            valor = int.Parse(Console.ReadLine());

            sucessor = valor + 1;
            antecessor = valor - 1;

            Console.WriteLine("o Sucessor do " + valor + " é " + sucessor );

            Console.WriteLine("o Antecessor do " + valor + " é " + antecessor);
        }
    }
}
