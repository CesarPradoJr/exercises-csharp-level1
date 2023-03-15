using System;
using System.Globalization;

namespace exercicio_08 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo imposto de renda simples!");
            Console.WriteLine("Entre com o valor do salário com duas casas decimais:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}