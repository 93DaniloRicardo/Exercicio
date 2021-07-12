using System;

namespace Exercicios20
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if(num%2==0)
            {
                Console.Write("Esse Numero é par");            
            }
            else
            {
                Console.Write("Esse numero é impar");
            }
        }
    }
}
