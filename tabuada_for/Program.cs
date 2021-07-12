using System;

namespace tabuada_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado;

            Console.Write("Digite primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            //Console.Write("digite segundo valor: ");
            //valor2 = int.Parse(Console.ReadLine());

            while(valor2 <= 10)
            {
                valor2++;
                resultado = valor1 * valor2;
                Console.WriteLine(valor1 + " x " + valor2 + " = " + resultado);
            }
            // for (var i = 0; i <= 10; i++)
            // {
            //     resultado = valor1 * i;
            //     Console.WriteLine(valor1 + " X " + i + " = " + resultado);
            // }
        }
    }
}
