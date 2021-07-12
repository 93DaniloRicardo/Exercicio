using System;

namespace Exercicios_73
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] logica = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int logica2 = 0;
            
            for (int i = 10; i > logica.Length; i--)
            {
                logica2 = logica2 - 1;
                Console.Write(" " + (logica[i] - logica2));
            }
        }
    }
}
