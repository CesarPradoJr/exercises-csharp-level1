using System;
using System.Globalization;

namespace aula_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Esse número é par!");
            }
            else { 
                Console.WriteLine("Esse número é impar!");
            }
        }
    }
}