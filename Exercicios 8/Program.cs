using System;

namespace Exercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double metros;
            double km;
            double hm;
            double dam;
            double dm;
            double cm;
            double mm;

            Console.Write("digite a distancia: ");
            valor = Convert.ToDouble(Console.ReadLine());

            metros = valor;
            km = valor / 1000;
            hm = valor / 100;
            dam = valor / 10;
            dm = valor * 10;
            cm = valor * 100;
            mm = valor * 1000;

            Console.WriteLine("a distancia de metros é: " + valor.ToString("F2")+ "\n");
            Console.WriteLine("a distancia em KM é: " + km.ToString("F2") + "\n");
            Console.WriteLine("a distancia de HM é: " + hm.ToString("F2") + "\n");
            Console.WriteLine("a distancia de DAM é: " + dam.ToString("F2") + "\n");
            Console.WriteLine("a distancia de DM é: " + dm + "\n");
            Console.WriteLine("a distancia de CM é: " + cm + "\n");
            Console.WriteLine("a distancia de MM é: " + mm + "\n");

        }   
    }
}
