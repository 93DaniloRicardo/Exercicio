using System;

namespace Exercicios41
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2 = 21;
            int total;
           
           while(num2 > 0)
           {
                num2--;
                total = num2 * 5;
                Console.WriteLine(total);
           }
                Console.WriteLine("Acabou! ");
           
           /*  for (int num = 20; num >= 0; num--)
            {
                num2 = num - 5;
                Console.WriteLine(num2);   
            } */
        }
    }
}
