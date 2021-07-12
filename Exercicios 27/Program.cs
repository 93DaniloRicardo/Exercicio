using System;

namespace Exercicios27
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota1;
            double Nota2;
            double Total;

            Console.Write("Digite a primeira nota: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Total = Nota1 + Nota2 / 2;
            Console.WriteLine("Média total: " + Total);

            if (Total < 4.9)
            {
                Console.WriteLine("REPROVADO");
            }
            else if (Total >= 5.0 && Total <= 6.9)
            {
                Console.WriteLine("RECUPERAÇÃO");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}
