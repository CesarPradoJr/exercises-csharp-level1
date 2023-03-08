using System;
using System.Globalization;

namespace Exercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int nroom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de um produto");
            double product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string lastname = dados[0];
            int age = int.Parse(dados[1]);
            double height = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(nroom);
            Console.WriteLine(product.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}