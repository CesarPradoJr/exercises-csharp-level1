using System;
using System.Globalization;

namespace exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Horas jogadas!");
            Console.WriteLine("Entre com o horário inicial e o horário final:");
            string[] horarios = Console.ReadLine().Split(' ');
            int inicial = int.Parse(horarios[0]);
            int final = int.Parse(horarios[1]);

            int valor;
            if ( inicial < final )
            {
                valor = inicial - final;
            } else
            {
                valor = 24 - inicial + final;
            }

            Console.WriteLine(valor);
        }
    }
}
