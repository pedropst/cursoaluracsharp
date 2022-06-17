using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2!");

            int idadeJoao = 17;
            int qntPessoas = 2;

            bool acompanhado = qntPessoas >= 2;

            if (idadeJoao > 18 || acompanhado == true)
            {
                Console.WriteLine("João tem mais de 18 anos ou está acompanhado!");
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
