using System;

namespace Exercicios_75
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3 = 0;
            Console.Write(f1 + " ");
            Console.Write(f2 + " ");
            int[] fibonacci = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            for (int i = 0; i < fibonacci.Length; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
