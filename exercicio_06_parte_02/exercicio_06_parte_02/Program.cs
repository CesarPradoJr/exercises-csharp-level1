using System;
using System.Globalization;

namespace exercicio_06
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Intervalo!");
            Console.WriteLine("Entre com um número:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0.0 && valor <= 25.0 ) {
                Console.WriteLine("Intervalo [ 0, 25].");
            } else if (valor > 25.0 && valor <= 50.0) {
                Console.WriteLine("Intervalo [ 25, 50].");
            }
            else if (valor > 50.0 && valor <= 75.0){
                Console.WriteLine("Intervalo [ 50, 75].");
            }
            else if (valor > 75.0 && valor <= 100.0){
                Console.WriteLine("Intervalo [ 75, 100].");
            } else {
                Console.WriteLine("Fora de Intervalo!");
            }
        }
    }
}
