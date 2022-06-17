using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos!");

            char primeiraLetra = 'p';
            Console.WriteLine("A primeira letra do meu nome é: " + primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine("A primeira letra do meu nome é: " + primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("A primeira letra do meu nome é: " + primeiraLetra);

            string titulo = "Pedro dono do universo!" + "desde " + 1998 + "!";
            Console.WriteLine(titulo);

            string cursosProgramacao =
@"- .NET
- Java
- JS";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
