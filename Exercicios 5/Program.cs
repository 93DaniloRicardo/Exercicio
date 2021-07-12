using System;

namespace Exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double valor2;
            double resultado;

            Console.Write("Digite primeiro valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            resultado = valor + valor2 / 2;

            Console.WriteLine("A soma do " + valor + " e " + valor2 + " é igual a " + resultado);
        }
    }
}
