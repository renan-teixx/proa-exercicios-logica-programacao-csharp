using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex26CategoriaDeProjeto
    {
        public static void Main(String[] args)
        {

            int quantidadeLinhasProjeto;

            Console.WriteLine("Categoriza o tamanho do seu projeto web baseado na quantidade de linhas.");

            Console.WriteLine("\nDigite quantas linhas tem o seu projeto: ");
            quantidadeLinhasProjeto = Convert.ToInt32(Console.ReadLine());

            if (quantidadeLinhasProjeto < 1000)
            {
                Console.WriteLine("\nPequeno porte");
            }
            else if (quantidadeLinhasProjeto <= 5000)
            {
                Console.WriteLine("\nMédio porte");
            }
            else
            {
                Console.WriteLine("\nGrande porte");
            }
        }
    }
}
