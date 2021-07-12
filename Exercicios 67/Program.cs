using System;

namespace Exercicios_67
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            int valor;
            string sair = "s";

            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            do
            {
                inicio++;
                Console.Write(inicio + ", " );
                

            } while (inicio < valor);

            Console.WriteLine("Acabou! ");
        }
    }
}
