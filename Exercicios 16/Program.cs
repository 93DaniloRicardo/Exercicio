using System;

namespace Exercicios16
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias;
            int anos;
            double vida;

            Console.Write("Quantidade de cigarros por dias? ");
            dias = int.Parse(Console.ReadLine());

            Console.Write("Quantos anos está fumando? ");
            anos = int.Parse(Console.ReadLine());

            vida = dias / anos;

            Console.Write("Perdeu cerca de " + vida + " dias de vida");


        }
    }
}
