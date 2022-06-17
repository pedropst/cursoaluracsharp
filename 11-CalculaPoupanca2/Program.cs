using System;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula Poupança 2!");

            double valorInvestido = 1000;
            double rend = 1.0036;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= rend;
                Console.WriteLine("Após " + contadorMes + " mês, você terá: R$" + valorInvestido);
            }

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
