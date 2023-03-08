using System;
using System.Globalization;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo valor peças!");
            Console.WriteLine("Informe o código, a quantidade e o valor da primeira peça");
            string[] peca1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(peca1[0]);
            int uni1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o código, a quantidade e o valor da segunda peça");
            string[] peca2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(peca2[0]);
            int uni2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double total = valor1 * uni1 + valor2 * uni2;

            Console.WriteLine("Valor a pagar: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}