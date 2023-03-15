using System;
using System.Globalization;

namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou ímpar:");
            Console.WriteLine("Digite um número inteiro:");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Par!");
            } else
            {
                Console.WriteLine("Ímpar!");
            }
        }
    }
}
