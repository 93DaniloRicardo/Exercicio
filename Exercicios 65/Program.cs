using System;

namespace Exercicios_65
{
    class Program
    {
        static void Main(string[] args)
        {
            //int final = 0;
            string num = "s";
            int inicio = 110;
            
            do
            {
                inicio -= 10;
                Console.WriteLine(inicio);
                Console.Write("digite 's' para continuar: ");
                num = Console.ReadLine();
            } while (num == "s");
            Console.WriteLine("Acabou! ");

        }
    }
}
