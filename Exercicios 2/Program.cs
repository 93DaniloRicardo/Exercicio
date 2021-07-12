using System;

namespace exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Qual seu nome? ");
            nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Olá " + nome + " prazer em te conhecer!");
        }
    }
}
