using System;

namespace Exercicios24
{
    class Program
    {
        static void Main(string[] args)
        {   
            double KM;
            double distanciacurta = 0.50;
            double distancialonga = 0.45;
            double totalC;
            double totalL;

            Console.Write("Quantos KM deseja ir? ");
            KM = Convert.ToDouble(Console.ReadLine());

            totalC = distanciacurta + KM;
            totalL = distancialonga + KM;

            if (KM <= 200)
            {  
                Console.WriteLine("Total a ser cobrado é: " + totalC);
            }
            else
            {
                Console.WriteLine("Total a ser cobrado é: " + totalL);
            }
        }
    }
}
