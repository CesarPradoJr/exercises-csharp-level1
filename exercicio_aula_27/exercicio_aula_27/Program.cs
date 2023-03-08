using System;
using System.Globalization;

namespace exercicio_aula_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int h1 = int.Parse(Console.ReadLine());

            if (h1 < 12){
                Console.WriteLine("Bom dia!");
            }else if (h1 >= 12 & h1 < 18) {
                Console.WriteLine("Boa tarde!");
            }else{
                Console.WriteLine("Boa noite!");
            }
        }
    }
}