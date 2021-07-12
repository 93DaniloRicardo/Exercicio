using System;

namespace Exercicios_72
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] logica = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
            int logica2 = 0;
            for (int i = 0; i < logica.Length; i++)
            {
                logica2 = logica2 + 4;
                Console.WriteLine(" " + (logica[i] + logica2 - 4));
            }
        }
    }
}
