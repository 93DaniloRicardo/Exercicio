using System;

namespace Exercicios19
{
    class Program
    {
        static void Main(string[] args)
        {
            String aluno;
            double Nota1;
            double Nota2;
            double total;
            Console.Write("Qual Nome do Aluno: ");
            aluno = Convert.ToString(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            total = Nota1 + Nota2 / 2;
            Console.WriteLine("Total: " + total);

            if(total >= 7 )
            {
                Console.WriteLine("O Aluno " + aluno + " passou de ano");
            }
            else 
            {
                Console.WriteLine("O Aluno " + aluno + " NÃO passou de ano");
            }
        }
    }
}
