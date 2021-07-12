using System;

namespace Exercicios42
{
    class Program
    {
        static void Main(string[] args)
        {
           int num;
           int num2 = 0;
           Console.Write("Digite um numero: ");
           num = int.Parse(Console.ReadLine());

            while (num2 < num)
            {
                num2++;
                Console.WriteLine(num2);
            }

                Console.WriteLine("Acabou! ");

            /* for (var i = 0; i <= num; i++)
            {  
                Console.WriteLine(i);  
            } */
        }   
    }
}
