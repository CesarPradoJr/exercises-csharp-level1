using System;
using System.Globalization;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de Valores Inteiros!");
            Console.WriteLine("Digite o primeiro valor:");
            int number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int number_2 = int.Parse(Console.ReadLine());

            int result = number_1 + number_2;

            Console.WriteLine("Soma = {0}", result);
        }
    }
}