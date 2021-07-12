using System;

namespace Exercicios_62
{
    class Program
    {
        static void Main(string[] args)
        {   

            int idade = 0;
            int ContadorIdade = 0;
            int ContadorMaiorIdade = 0;
            double media = 0;
            string op;

            Console.Write("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine()); 

                do
                {
                            if(idade > 21)
                        {
                            ContadorMaiorIdade = ContadorMaiorIdade + 1;
                        }
                            if (idade > 0)
                        {
                            ContadorIdade = ContadorIdade + 1;
                        }

                        Console.Write("Digite uma idade: ");
                        idade = int.Parse(Console.ReadLine());

                        media = media + idade;

                        
                        Console.Write("Deseja informar outro numero? s/n ");
                        op = Console.ReadLine();
                        //op = op.toLower();
                        
                }while (op == "s");
            
                Console.WriteLine("Quantidade de vezes a idade foi digitada: " + ContadorIdade);
                Console.WriteLine("Quantas vezes que o idade maior de 21 anos foi digitado: " + ContadorMaiorIdade);
                Console.WriteLine("Média de idade: " + media);
            
        }
    }
}
