using System;

namespace Exercicios68
{
    class Program
    {
        static void Main(string[] args)
        {
            int sexo;
            double pesoM, pesoH;
            int pesoH100 = 0, ContadorMulheres = 0, MaiorPesoHomem = 0;
            string sair = "s";
            double MediaPesoM = 0;
               
                Console.Write("Digite o sexo da pessoa: (1) homem ou (0) mulher ");
                sexo = int.Parse(Console.ReadLine());
                
                Console.Write("Qual o peso das mulheres? ");
                pesoM = Convert.ToDouble(Console.ReadLine());

                Console.Write("Qual o peso do homem? ");
                pesoH = Convert.ToDouble(Console.ReadLine());

            do
            {
                if(sexo == 0)
                {
                    Console.WriteLine("Você digitou mulher ");
                    ContadorMulheres = ContadorMulheres + 1;

                }
                else if(sexo == 1)
                {
                    Console.WriteLine("Você digitou homem ");
                }
                else 
                {
                    Console.WriteLine("Programa Encerrado!");
                    Environment.Exit(2);
                }
                if(pesoH > 100)
                {
                    pesoH100 = pesoH100 + 1;
                }
                if(sexo > pesoH )
                {
                    MaiorPesoHomem = MaiorPesoHomem + 1;
                }

                Console.Write("Digite o sexo da pessoa: (1) homem ou (0) mulher ");
                sexo = int.Parse(Console.ReadLine());
                
                Console.Write("Qual o peso das mulheres? ");
                pesoM = Convert.ToDouble(Console.ReadLine());

                Console.Write("Qual o peso do homem? ");
                pesoH = Convert.ToDouble(Console.ReadLine());

                Console.Write("Para continuar, digite 's': ");
                sair = Console.ReadLine();
            } while (sair == "s");

            //a) Quantas mulheres foram cadastradas
            Console.WriteLine("Quantidade de mulheres registrada: " + ContadorMulheres);
            //b) Quantos homens pesam mais de 100Kg
            Console.WriteLine("Quantidade de homens que pesam mais de 100 Kg: " + pesoH100);
            //c) A média de peso entre as mulheres
            Console.WriteLine("A média de peso entre as mulheres: " + MediaPesoM);
            //d) O maior peso entre os homens
            Console.WriteLine("Maior peso entre os homens: " + MaiorPesoHomem);


                /* //Console.WriteLine("Resultado: ");
                Console.Write("Qual o peso das mulheres? \n\n");
                pesoM = Convert.ToDouble(Console.ReadLine());

                Console.Write("Qual a altura da mulher? \n\n ");
                AlturaM = Convert.ToDouble(Console.ReadLine());

                IMCTotal2 = pesoM / (pesoM * AlturaM);
                Console.Write("A média de peso dos Mulheres \n\n: " + IMCTotal2);

                Console.Write("Qual o peso do homem? \n\n");
                pesoH = Convert.ToDouble(Console.ReadLine());

                Console.Write("Qual a altura do Homem?\n\n ");
                AlturaH = Convert.ToDouble(Console.ReadLine());
                
                IMCTotal1 = pesoH / (pesoH * AlturaH);
                
                Console.Write("A média de peso das Homens:\n\n " + IMCTotal1); */
            
        }
    }
}
