using System;

namespace Exercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double dobro;
            double divisao;

            Console.Write("Digite um número: ");
            valor = Convert.ToDouble(Console.ReadLine());

            dobro = valor * 2;
            divisao = valor / 3;

            Console.WriteLine("O valor de " + valor + " o dobro é igual a " + dobro);
            Console.WriteLine("O valor de " + valor + " primeira terço é igual a " + divisao);
        }
    }
}
