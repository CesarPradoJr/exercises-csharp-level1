using System;
using System.Globalization;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de salário!");
            Console.WriteLine("Qual o número do funcionário?");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o número de horas trabalhadas pelo funcionário?");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor que o funcionário recebe por hora?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor * horas;

            Console.WriteLine("Number = {0}", matricula);
            Console.WriteLine("Salary = U$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}