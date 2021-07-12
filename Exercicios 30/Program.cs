using System;

namespace Exercicios30
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Digite 3 lados para formar! ");

            Console.Write("Digite lado A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite lado B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite lado C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if((A < B + C) && (B < A + C) && (C < A + B))
            {
                Console.WriteLine("Formam um triangulo!\n\n");
             
                        if((A == B) && (B==C))
                    {
                        Console.WriteLine("Forma um triangulo Equilátero\n\n ");
                    }
                    else if ((A == B) || (B == C) || (A == C))
                    {
                        Console.WriteLine("Forma um triangulo isóqueles \n\n");
                    }
                    else 
                    {
                        Console.WriteLine("Forma um triangulo Escaleno\n\n");
                    }
            }
                else
            {
                Console.WriteLine("Não forma um triangulo ");
            }
        }   
        
    }
}
