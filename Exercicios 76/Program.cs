using System;

namespace Exercicios_76
{
    class Program
    {
        static void Main(string[] args)
        {

            Random NumAleatorio = new Random();
            int computador = NumAleatorio.Next(0,7);

            int [] valor = {1,2,3,4,5,6,7};

            for (int i = 0; i < valor.Length; i++)
            {
                Console.Write(computador + " "); 
                computador = NumAleatorio.Next(0,7);
            }
        }
    }
}
