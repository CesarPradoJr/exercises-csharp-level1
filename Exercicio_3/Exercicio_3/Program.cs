using System;
using System.Globalization;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cáculo da diferença dos produtos!");
            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D:");
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;
            Console.WriteLine("Diferença = {0}", diferenca);
        }
    }
}
