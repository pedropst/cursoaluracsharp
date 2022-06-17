using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo!");

            int idadeJoao = 17;
            int qntPessoas = 2;
            bool acompanhado = qntPessoas >= 2;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "Não está acompanhado.";
            }

            if (idadeJoao > 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João possui menos que 18 anos!");
            }

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
