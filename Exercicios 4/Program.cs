using System;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int valor2;
            int resultado;

            Console.Write("Qual o primeiro valor: ");
            valor = int.Parse(Console.ReadLine());

            Console.Write("Qual o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            resultado = valor + valor2;

            Console.WriteLine("A Soma de " + valor + " e " + valor2 + " é igual a " + resultado);
        }
    }
}
