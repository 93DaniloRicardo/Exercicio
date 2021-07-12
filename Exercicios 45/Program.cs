using System;
namespace Exercicios44
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;
            int incremento;
            //int soma;

            Console.Write("Digite primeiro valor: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Digite o último valor: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("digite o valor do incremento: ");
            incremento = int.Parse(Console.ReadLine());
            
            if(num2 < num)
            {
                Console.Write(num2 + " ");
                num2 = num2 + incremento;
            }
                else
            {
                while (num < num2) 
                {                
                    Console.Write(num + " ");
                    num = num + incremento;
                }
            }

            
           Console.WriteLine("Acabou! ");
        }
    }
}