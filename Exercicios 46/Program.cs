using System;

namespace Exercicios46
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int num2 = 100;
            int total = 2;
            int final = 0;
                
            while(num < num2)
            {
                num = num + total;
                Console.Write(num + " + ");
                final = num + final; 
            }
            Console.WriteLine(" = " + final);
        }
    }
}
