using System;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança!");

            double valorInvestido = 1000;
            double rend = 0.0036;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * rend;
                Console.WriteLine("Após " + contadorMes + " mês, você terá: R$" + valorInvestido);
                contadorMes++;
            }

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
