using System;

namespace Exercicio04.ConsoleApp1
{
    internal class N
    {
        static void Main(string[] args)
        {
            int resultado;
            
            Console.WriteLine("Digite um valor entre 1 e 10:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < 11; a++)
            {
                resultado = n * a;

                Console.WriteLine(a + " x " + n + " = " + resultado);
            }

        }
    }
}
