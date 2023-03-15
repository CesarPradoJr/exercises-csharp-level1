using System;
using System.Globalization;

namespace exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplos");
            Console.WriteLine("Entre com dois números inteiros:");
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % 2 == 0 || B % 2 == 0)
            {
                Console.WriteLine("São Multiplos!");
            }
            else
            {
                Console.WriteLine("Não são multiplos!");
            }
        }
    }
}