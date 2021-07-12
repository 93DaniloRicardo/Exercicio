using System;

namespace Exercicios11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double delta = 0;
            double baskara1 = 0;
            double baskara2 = 0;
            //double baskara = 0;
            Console.Write("digite primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo Valor: ");
            b = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o terceiro Valor: ");
            c = double.Parse(Console.ReadLine());

            if(a <= 0 && b <= 0 && c <= 0) 
            {
                Console.WriteLine("Numero nao pode ser menor que 0");
            }
                else
            {
                delta = (Math.Pow(b, 2)) - (4 * a * c);
                Console.WriteLine("O valor de Delta é: " + delta);
            }
                if(delta < 0)
            {
                Console.WriteLine("Delta não pode ser menor que zero!");
            }
            else
            {
       
                baskara1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Primeiro valor: " + baskara1.ToString("F4"));
                baskara2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Segundo Valor: " + baskara2.ToString("F4"));

            }        
            
        }
    }
}
