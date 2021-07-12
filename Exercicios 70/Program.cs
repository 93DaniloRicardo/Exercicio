using System;

namespace Exercicios_70
{
    class Program
    {
        static void Main(string[] args)
         {
            int i, contador, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Informe o limite : ");
            contador = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= contador; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
