using System;
using System.Globalization;

namespace exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 )
            {
                Console.WriteLine("Esse número é NEGATIVO!");
            }
            else
            {
                Console.WriteLine("Esse número é POSITIVO!");
            }
        }
    }
}