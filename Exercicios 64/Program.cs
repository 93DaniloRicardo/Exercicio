using System;

namespace Exercicios_64
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            string num = "s";
           // int final = 30;

            do
            {
                inicio += 5;
                Console.WriteLine(inicio);
            
                Console.Write("digite 's' para continuar: ");
                num = Console.ReadLine();
            } while (num == "s");
            Console.WriteLine("Acabou! ");
            
        }
    }
}
