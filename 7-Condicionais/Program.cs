using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais!");

            int idadeJoao = 17;
            int qntPessoas = 2;

            if (idadeJoao > 18)
            {
                Console.WriteLine("João tem mais de 18 anos!");
            }
            else
            {
                if (qntPessoas >= 2)
                {
                    Console.WriteLine("João não tem mais que 18, mas está acompanhado!");
                }
                else
                {
                    Console.WriteLine("João possui menos que 18 anos!");
                }
            }

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
