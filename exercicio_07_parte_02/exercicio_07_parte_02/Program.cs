using System;
using System.Globalization;

namespace exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plano Cartesiano!");
            Console.WriteLine("Entre com os valores de x e y respectivamente:");

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0){
                Console.WriteLine("Q4");
            } else {
                Console.WriteLine("Origem");
            }

            
        }
    }
}