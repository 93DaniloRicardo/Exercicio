using System;

namespace Exercicios36
{
    class Program
    {
        static void Main(string[] args)
        {
            double pontos = 0.05;
            int horas;
            double total;
           // int cliente; 
            
            Console.Write("Quantas Horas o cliente fez atividade fisica? ");
            horas = int.Parse(Console.ReadLine());

                if(horas < 10)
            {
                total = 10 + (pontos * 2);
                Console.WriteLine("o cliente ganha 2 pontos por hora: " + total);
            }
                else if(horas > 10 && horas < 20)                
            {
                total = 20 + (pontos * 5);
                Console.WriteLine("o cliente ganha 5 pontos por hora: " + total);
            }
                else
            {
                total = 21 + (pontos * 10);
                Console.WriteLine("O cliente ganha 10 pontos por hora: " + total);
            }




        }
    }
}
