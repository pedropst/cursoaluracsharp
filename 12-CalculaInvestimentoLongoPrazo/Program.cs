using System;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Calcula investimento de longo prazo!");

            double valorInvestido = 1000;
            double rend = 1.0036;

            for (int contadorAno = 0; contadorAno < 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= rend;
                    Console.WriteLine("Após " + contadorAno + " ano " +contadorMes + " mês, você terá: R$" + valorInvestido);
                }
                rend += 0.001;
            }

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
