using System;

namespace Exercicios23
{
    class Program
    {
        static void Main(string[] args)
        {   
            double descontoH = 5.0 / 100;
            double descontoM = 13.0 / 100;
            int sexo;
            int homem = 1;
            int mulher = 2;
            double valor;
            double totalH;
            double totalM;

            Console.Write("Digite o valor da compra: ");
            valor = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite o sexo? 1(homem) ou 2(mulher): ");
            sexo = int.Parse(Console.ReadLine());

            if(sexo == 1)
            {
                totalH = valor - (descontoH * valor);
                Console.WriteLine("Valor total de desconto é: " + totalH.ToString("F2"));
            }
            else if (sexo == 2)
            {
                totalM = valor - (descontoM * valor);
                Console.WriteLine("Valor total de desconto é: " + totalM.ToString("F2"));
            }
            else 
            {
                {
                Console.WriteLine("Programa fechado");
                Environment.Exit(0);
            }
            }
        }
    }
}
