using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Atribuições de variáveis!");

            int idade = 32;
            int idadePedro = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadePedro);

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
