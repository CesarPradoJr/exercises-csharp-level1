using System;
using System.Globalization;

namespace aula_30 {
    class Program {
        static void Main(string[] args)
        {
            /*console.writeline("digite três números inteiros:");
            string[] valores = console.readline().split(' ');
            int a = int.parse(valores[0]);
            int b = int.parse(valores[1]);
            int c = int.parse(valores[2]);

            if (a > b && a > c){
                console.writeline(a + " é o maior número!");
            }else if (b > c && b > a) {
                console.writeline(b + " é o maior número!");
            }else { 
                console.writeline(c + " é o maior número"); 
            }*/


            Console.WriteLine("Digite três números inteiros:");
            string[] num = Console.ReadLine().Split(' ');
            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);
            int n3 = int.Parse(num[2]);

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

            static int Maior (int a , int b, int c)
            {
                int m;
                if (a > b && a > c)
                {
                    m = a;
                }
                else if (b > c && b > a)
                {
                    m = b;
                }
                else
                {
                    m = c;

                }

                return m;
            }

        }
    }
}