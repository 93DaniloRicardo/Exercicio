using System;

namespace Exercicios14
{
    class Program
    {
        static void Main(string[] args)
        {   
            double km;
            int dia;
            double total;

            Console.Write("Quantos dias o carro foi alugado? ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Quantos KM o carro percorreu? ");
            km = double.Parse(Console.ReadLine());
            total= ((km * 0.2) + (dia * 90));

            Console.WriteLine("Valor Total: " + total);
        }
    }
}
