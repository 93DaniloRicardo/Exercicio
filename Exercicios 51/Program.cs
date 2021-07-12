using System;

namespace Exercicios51
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inicio = 0;
            int Fim = 7;
            double preco;
            double maiorPreco = 0.0, menorPreco;

            Console.Write("digite um valor: ");
            preco = Convert.ToDouble(Console.ReadLine());
            menorPreco = preco;
            
            while(Inicio < Fim)
            {
                if(preco > maiorPreco){
                    maiorPreco = preco;
                }

                if(preco < menorPreco){
                    menorPreco = preco;
                }
                Console.Write("digite um valor: ");
                preco = Convert.ToDouble(Console.ReadLine());
            
                Inicio++;
            }  
            Console.WriteLine("o Maior valor é: " + maiorPreco);
            Console.WriteLine("O menor valor é: " + menorPreco);
           
        }
    }
}
