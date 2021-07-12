using System;

namespace Exercicios43
{
    class Program
    {
        static void Main(string[] args)
        {   
            int A = 30;
            while(A >= 1 )
            {   
                A--;
                    if(A%5 == 0)
                {
                    Console.Write("[" + A + "] ");
                }
                    else
                {
                    Console.Write(A + " ");
                }
            }
            /* for (var i = 30; i >= 1; i--)
            {
                if(i%4 == 0){
                    Console.Write("[" + i + "] ");
                }
                Console.Write(i +" ");
            } */
        }
    }
}
