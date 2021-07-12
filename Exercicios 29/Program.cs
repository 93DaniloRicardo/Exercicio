using System;

namespace Exercicios29
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int ano;
            double acressimo1 = 3.0 / 100;
            double acressimo2 = 12.5 / 100;
            double acressimo3 = 20.0 / 100;
            double total1;
            double total2;
            double total3;
            double salario;
            

            Console.Write("Qual nome do funcionario? " );
            nome = Convert.ToString(Console.ReadLine());

            Console.Write("quantos anos o funcionário trabalha? ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("Quantos que o funcionário recebe? ");
            salario = Convert.ToDouble(Console.ReadLine());

            total1 = salario + (salario * acressimo1);
            total2 = salario + (salario * acressimo2);
            total3 = salario + (salario * acressimo3);

            if (ano >= 0 && ano <=2)
            {
                Console.WriteLine("O funcionario " + nome + " teve o seu salario aumentado em 3%, então foi para " + total1);
            }
            else if(ano >= 3 && ano <= 10)
            {
                Console.WriteLine("O funcionario " + nome + " teve o seu salario aumentado em 12.5%, então foi para " + total2);
            }
            else 
            {
                Console.WriteLine("O funcionario " + nome + " teve o seu salario aumentado em 20%, então foi para " + total3);
            }
        }
    }
}
