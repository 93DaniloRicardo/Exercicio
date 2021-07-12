using System;

namespace Exercicios34
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double totalIMC;
            
            Console.Write("Qual o peso da pessoa? ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Qual a altura da pessoa? ");
            altura = double.Parse(Console.ReadLine());

            totalIMC = peso / (altura * altura);
            
            Console.WriteLine(totalIMC.ToString("F2"));

            if(totalIMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if(totalIMC > 18.5 && totalIMC < 25)
            {
                Console.WriteLine("Peso Ideal!");
            }
            else if(totalIMC > 25 && totalIMC < 30)
            {
                Console.WriteLine("Sobrepeso!");
            }
            else if (totalIMC > 30 && totalIMC < 40)
            {
                Console.WriteLine("Obesidade!");
            }
            else
            {
                Console.WriteLine("Obesidade Mórbida!");
            }
        }
    }
}
