using System;

namespace Exercicios_77
{
    class Program
    {
        static void ExibirValores (int [] v, int tl)
        {
            Console.WriteLine("Valores presentes no vetor");
            for(int i = 0; i < tl; i++)
            {
                Console.Write(v[i] + ", ");
            }
            Console.WriteLine("");
        }
        static void Main(int[] args)
        {
            int [] nome = [7];
            int valor; 
            string nome1 = "", nome2 = "";
            //Console.Write("Digite 7 nomes: ");
            //valor = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < nome.Length; i++)
            {
               // Console.Write("Digite 7 nomes: ");
                //valor = Convert.ToString(Console.ReadLine());
                nome1 += nome.Length[i];

            }

            int [] nomeRevertido =  new int [nome.Length];

            for(int i = 0;i < nome.Length; i++)
            {
                nomeRevertido[i] = nome[nome.Length - 1 - i];
            }            
            
            for(int i = 0; i < nomeRevertido.Length; i++ )
            {
                nome2 += nomeRevertido[i];
            }
            Console.WriteLine("nomes normais: " + nome1 +
                                "/n"
                                + "nome revertido: " + nome2);
            
        }
    }
}
