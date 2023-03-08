using System;
using System.Globalization;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C;
            double pi = 3.14159;
            Console.WriteLine("Cálculo de área!");
            Console.WriteLine("Digite três valores:");
            string[] valores = Console.ReadLine().Split(' ');
            A = float.Parse(valores[0], CultureInfo.InvariantCulture);
            B = float.Parse(valores[1], CultureInfo.InvariantCulture);
            C = float.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2;
            double circulo = pi * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;


            Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}