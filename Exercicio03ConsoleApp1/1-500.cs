using System;

namespace Exercicio03ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[500];
            int soma = 0;
            int n = 0;
            
            for (int a = 1; a < 501 ; a++)
            {
                numeros[n] = a;
                n++;

            }
            foreach (int i in numeros)
            {
                if (i % 3 == 0 && i % 2 !=0)
                {
                    soma = soma + i;
                    
                    
                }
                
            }
            Console.WriteLine(soma);
        }

    }
}
