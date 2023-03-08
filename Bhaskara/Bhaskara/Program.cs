using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem Vindo ao nosso cáculo de Bhaskara");
            Console.WriteLine("Digite o primeiro número do cálculo:");
            double nA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número do cálculo:");
            double nB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número do cálculo:");
            double nC = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(nB, 2) - 4 * nA * nC;
            double x1 = (-nB + Math.Sqrt(delta)) / (2 * nA);
            double x2 = (-nB - Math.Sqrt(delta)) / (2 * nA);

            Console.WriteLine("Resultado:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}