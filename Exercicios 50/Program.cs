using System;

namespace Exercicios50
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            int inicio = 1;
            int final = 21;
            int divisiveis = 0;
            //int acima = 0;
            //int menor = 0;

            Random NumAleatorio = new Random();
            int numeroSorteado = NumAleatorio.Next(1, 10);

            while( inicio < final)
            {
                //Console.WriteLine(numeroSorteado + " "); 
                numeroSorteado = NumAleatorio.Next(1, 10); 
                inicio++; 
            
                    if (numeroSorteado>5)
                {
                    Console.WriteLine("Numeros maiores que 5: " + numeroSorteado);
                }
                    else 
                {
                    Console.WriteLine("Numeros menores que 5: " + numeroSorteado);
                }
                Console.WriteLine("Numeros divisiveis a 3: " + (numeroSorteado %3));
            }
            
        }
    }
}
