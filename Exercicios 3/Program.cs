using System;

namespace exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario;

            Console.Write("Nome do funcionário: ");
            nome = Convert.ToString(Console.ReadLine());

            Console.Write("Salário do Funcionário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            //nome + salario;

            Console.WriteLine("O funcionário " + nome + " Recebeu " + salario + " em Junho");
        }
    }
}
