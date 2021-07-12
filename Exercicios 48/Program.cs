using System;

namespace Exercicios48
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 8;
            int c = 0;
            int d = 0;

            //Console.Write("Digite o primeiro valor: ");
            //b = int.Parse(Console.ReadLine());

            /*Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());*/

            while (a < b)
            {
                a++;
               // a = a+ b;
                c = a + b;
                Console.WriteLine(a + " + " + b + " = " + c);
                d = d + c;
            }
            Console.WriteLine("Resultado de todos as somas é: " + d);
        }
    }
}
