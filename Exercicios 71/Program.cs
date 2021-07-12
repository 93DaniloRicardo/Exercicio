using System;

namespace Exercicios_71
{
    class Program
    {
        static void Main(string[] args)
        {/* 
            int [,] numeros = new int [3, 5];
            
            numeros[0, 0] = 1;  numeros[0, 1] = 2;  numeros[0, 2] = 3;  numeros[0, 3] = 4;  numeros[0, 4] = 5;
            numeros[1, 0] = 6;  numeros[1, 1] = 7;  numeros[1, 2] = 8;  numeros[1, 3] = 9;  numeros[1, 4] = 10;
            numeros[2, 0] = 11; numeros[2, 1] = 12; numeros[2, 2] = 13; numeros[2, 3] = 14; numeros[2, 4] = 15;
            
            */ int[] teste = {999, 999, 999, 999, 999, 999, 999, 999};
            for (int i = 0; i < teste.Length; i++)
            {
                Console.Write(" [" + teste[i] + "] ");
            }

            /* Console.WriteLine();

            for( int i = 0; i < teste.Length; i++ )
            {
                Console.WriteLine("Posição {0}: {1}", i, teste[i]);
            } */
        }
    }
}
