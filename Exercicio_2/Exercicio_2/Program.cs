using System;
using System.Globalization;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cáculo área do círculo!");
            Console.WriteLine("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = {0}", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}