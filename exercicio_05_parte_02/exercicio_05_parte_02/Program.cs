using System;
using System.Globalization;

namespace exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor compra!");
            Console.WriteLine("Entre com código e a quantidade de pordutos:");
            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double total;
            if (cod == 1) {
                total = qtd * 4.0;
            } else if (cod == 2) {
                total = qtd * 4.5;
            } else if (cod == 3) {
                total = qtd * 5.0;
            } else if (cod == 4){
                total = qtd * 2.0;
            } else if (cod == 5) {
                total = qtd * 1.5;
            } else {
                total = 0;
            }

            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));

            if ( cod != 1 && cod != 2 && cod != 3 && cod != 4 && cod != 5) {
                Console.WriteLine("Produto não cadastrado na base de dados.");
            }
        }
    }
}