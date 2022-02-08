using System;

namespace Exerciocio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] altura = new decimal[15];

            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write("Digite sua altura: ");
                altura[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Array.Sort(altura);
            Console.WriteLine("Menor altura: " + altura[0]);
            Console.WriteLine("Maior altura: " + altura[14]);
        }
    }
}

