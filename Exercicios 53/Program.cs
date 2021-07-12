using System;

namespace Exercicios53
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pessoas;
            //int Idade;
            int Sexo;
            int Inicio = 0;
            int Final = 5;
            int ContadorHomens = 0;
            int ContadorMulheres = 0;
            int ContadorMulheresIdade = 0;
            int MediaGrupo;
           
           Console.Write("digite a idade de 5 pessoa: ");
           Pessoas = int.Parse(Console.ReadLine());

           Console.Write("Digite o sexo da pessoa: (0) - Homem e (1) Mulher ");
           Sexo = int.Parse(Console.ReadLine());

           

            while(Inicio < Final)
            {
                if(Sexo == 0)
                {
                    Console.WriteLine("Você digitou Homem ");
                    ContadorHomens = ContadorHomens + 1;
                } 
                else if(Sexo == 1)
                {
                    Console.WriteLine("você digitou Mulher ");
                    ContadorMulheres = ContadorMulheres +1;
                }
                else
                {
                    Console.WriteLine("Programa Encerrado! ");
                    Environment.Exit(2);
                }

                if(Pessoas > 20)
                {
                    ContadorMulheresIdade = ContadorMulheresIdade + 1;
                }
                Console.Write("Digite 5 idade das pessoas: ");
                Pessoas = int.Parse(Console.ReadLine());

                Console.Write("Digite o sexo da pessoa: (0) - homem e (1) mulher ");
                Sexo = int.Parse(Console.ReadLine());
                Inicio++;
            }
            //a
            Console.WriteLine("Quantidades de homens registrado: " + ContadorHomens);
            //b
            Console.WriteLine("Quantidades de mulheres registrada: " + ContadorMulheres);
            //c
            Console.WriteLine("A média do grupo: " + (MediaGrupo = Pessoas / 10));
            //d
            Console.WriteLine("Média da idade dos homens: " );
            //e
            Console.WriteLine("Quantidades de Mulheres com maior de 20 anos: " + ContadorMulheresIdade);
        }
    }
}
