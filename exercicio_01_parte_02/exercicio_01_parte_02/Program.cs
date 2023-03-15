using System;
using System.Globalization;

namespace exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Negativo ou Positivo?");
            Console.WriteLine("Digite um número inteiro:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0) {
                Console.WriteLine("Negativo!");
            } else { Console.WriteLine("Positivo!"); }
        }
    }
}
