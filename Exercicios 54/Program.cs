using System;

namespace Exercicios54
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inicio = 0;
            int Final = 7;
           // int Pessoa;
            double AlturaPessoa, contadorPeso50e160 = 0, contadorPeso100eAltura190 = 0; 
            //double MédiaAltura;
            int PesoPessoa = 0;
            int contadorPesoPessoa = 0;

            Console.Write("Digite o peso da pessoa: ");
            PesoPessoa = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura da pessoa: ");
            AlturaPessoa = double.Parse(Console.ReadLine());

            while(Inicio < Final)
            {
                if(PesoPessoa > 90)
                {
                    contadorPesoPessoa = contadorPesoPessoa + 1;
                }
                if(AlturaPessoa > 1.90 && PesoPessoa > 100)
                {
                  contadorPeso100eAltura190 = contadorPeso100eAltura190 +1;
                }
                if(PesoPessoa < 50 && AlturaPessoa < 1.60)
                {
                    contadorPeso50e160 = contadorPeso50e160 + 1;
                }
                Console.Write("Digite o peso da pessoa: ");
                PesoPessoa = int.Parse(Console.ReadLine());

                Console.Writed("Digite a altura da pessoa: ");
                AlturaPessoa = double.Parse(Console.ReadLine());

                Inicio++;
            }
            //a) Qual foi a média de altura do grupo
            Console.WriteLine("A média do grupo é: " );
            //b) Quantas pessoas pesam mais de 90Kg
            Console.WriteLine("Quantidades de pessoas que pesam mais de 90 kilos: " + contadorPesoPessoa);
            //c) Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m
            Console.WriteLine("Quantidade de pessoas que pesam menos de 50 kilo e menos de 1.60m: " + contadorPeso50e160);
            //d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.
            Console.WriteLine("Quantidade de pessoas que tem mais de 1.90m e pesam menos de 100 kilos: " + contadorPeso100eAltura190);
        }
    }
}
