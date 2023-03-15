using System;
using System.Globalization;

namespace exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Senha!");
            Console.WriteLine("Entre com sua senha:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2022)
            {
                Console.WriteLine("Senha Incorreta!");
                Console.WriteLine("Digite novamente sua senha:");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha Correta!");
        }
    }
}