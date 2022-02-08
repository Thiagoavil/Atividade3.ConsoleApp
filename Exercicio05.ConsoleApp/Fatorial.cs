using System;

namespace Exercicio05.ConsoleApp
{
    internal class Fatorial
    {
        static void Main(string[] args)
        {
            
           
            int n ;
            int i;

            Console.WriteLine("Digite um valor inteiro");
            n = Convert.ToInt32(Console.ReadLine());
            int fatorial = n;
            string nome = n + "! = " + n  ;

            for (i = n - 1 ;i > 0; i--  ) 
            {
                fatorial = fatorial * i;
                nome =  nome + " x " + i  ;


                                 
                            
                
            }
               Console.WriteLine( nome + " = " + fatorial);


        }
    }
}
