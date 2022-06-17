using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Conversões e outros tipos numéricos!");

            double salario;
            salario = 1200.50;
            Console.WriteLine("O salário correto é: " + salario);

            int salarioInt = (int)salario;   //NÚMERO QUE OCUPA 32 BITS DE MEMÓRIA
            Console.WriteLine("O salário arredondado é: " + salarioInt);

            long idadeUniverso = 13000000000;  //NÚMERO QUE OCUPA 64 BITS DE MEMÓRIA
            Console.WriteLine("A idade do universo é: " + idadeUniverso);

            short quantidadeProdutos = 150; //NÚMERO QUE OCUPA 16 BITS DE MEMÓRIA
            Console.WriteLine("A quantidade de produtos é: " + quantidadeProdutos);

            float altura = 1.78f; //FLOAT PRECISA COLOCAR O "f" NO FINAL DO NÚMERO
            Console.WriteLine("A sua altura é de: " + altura);

            Console.WriteLine("Tecle Enter para finalizar . . .");
            Console.ReadLine();
        }
    }
}
