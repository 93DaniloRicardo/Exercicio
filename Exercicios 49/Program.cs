using System;

namespace Exercicios49
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 6;
            //int d = 0; 
            
            while(a < c || b < c)
            {
                a = a + 2;
                b = b + 2;
                Console.WriteLine("Esse Numero é par: " + a);
                Console.WriteLine("Esse Numero é impar: " + b);
            }  
                //Console.WriteLine("quantidade total de impares e par:" + (d = a + b));




            
                    /* 
                    //string op = "s";
                    
                    while(op == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Digite 1 numero: ");
                    a = int.Parse(Console.ReadLine());

                     if(a%2 == 0)
                    {
                        Console.WriteLine("é numero par: " );
                    }   
                        else
                    {
                        Console.WriteLine("é numero impar: " );
                    }  
                    op = "X";
                    while = ((op != "s") && (op != "n"))
                    Console.Write("Deseja informar outro numero? s/n ");
                    op = Console.ReadLine();
                    //op = op.ToLower(); 
                }*/ 
                
        }
    }
}
