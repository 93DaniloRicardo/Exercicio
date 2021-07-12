using System;

namespace Exercicios33
{
    class Program
    {
        static void Main(string[] args)
        {
            double emprestimo = 30.0 / 100;
            double casa;
            double salario;
            double pagamento;
            double total;

            Console.Write("Qual Valor da Casa? ");
            casa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual o salario do comprador? ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantos anos o comprador pretende continuar pagando? ");
            pagamento = Convert.ToDouble(Console.ReadLine());

            total = salario - (salario * emprestimo);
            
            Console.WriteLine(total <=);

            

        }
    }
}
