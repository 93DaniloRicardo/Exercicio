using System;

namespace Exercicios15
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mes;
            int dias;
            int horas = 200;
            double salario;
            Console.Write("Quantos dias o trabalhador trabalhou? ");
            dias = int.Parse(Console.ReadLine());

            salario = horas * dias;

            Console.WriteLine("Salario Total: " + salario);


        }
    }
}
