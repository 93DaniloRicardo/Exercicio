using System;

namespace Exercicios26
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.Write("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine("Numero 2 é maior que o Numero 1");
                Environment.Exit(0);
            }
            else if(numero1 > numero2)
            {
                Console.WriteLine("Numero 1 é maior que o Numero 2");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Nenhum é maior que o outro, são iguais");
                Environment.Exit(0);
            }
        }
    }
}
