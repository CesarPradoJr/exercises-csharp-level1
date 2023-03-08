using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem vindo a nossa tabuada.");
            Console.WriteLine("Digite o número que você deseja ver a tabuada:");
            int nCalculo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado:");

            int n1 = nCalculo * 1;
            int n2 = nCalculo * 2;
            int n3 = nCalculo * 3;
            int n4 = nCalculo * 4;
            int n5 = nCalculo * 5;
            int n6 = nCalculo * 6;
            int n7 = nCalculo * 7;
            int n8 = nCalculo * 8;
            int n9 = nCalculo * 9;
            int n10 = nCalculo * 10;

            Console.WriteLine($"{nCalculo} x 1 =  {n1}");
            Console.WriteLine($"{nCalculo} x 2 =  {n2}");
            Console.WriteLine($"{nCalculo} x 3 =  {n3}");
            Console.WriteLine($"{nCalculo} x 4 =  {n4}");
            Console.WriteLine($"{nCalculo} x 5 =  {n5}");
            Console.WriteLine($"{nCalculo} x 6 =  {n6}");
            Console.WriteLine($"{nCalculo} x 7 =  {n7}");
            Console.WriteLine($"{nCalculo} x 8 =  {n8}");
            Console.WriteLine($"{nCalculo} x 9 =  {n9}");
            Console.WriteLine($"{nCalculo} x 10 = {n10}");
        }
    }
}
