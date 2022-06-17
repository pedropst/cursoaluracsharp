using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variaveis do tipo Ponto Flutuante!");
            double salario;
            salario = 1215;
            Console.WriteLine("Seu salário é de: " + salario);

            double metadeSalario;
            metadeSalario = salario / 2;
            Console.WriteLine("Seu salário é de: " + metadeSalario);

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
