using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex25DescontoPorSetor
    {
        public static void Main(String[] args)
        {

            float preco, precoFinal;
            int codigo;

            Console.WriteLine("Aplica um desconto diferente dependendo do departamento do seu produto.");

            Console.WriteLine("\nDigite o valor do seu produto: ");
            preco = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o número referente a qual departamento ele pertence: \n1 - Hardware \n2 - Software \n3 - Redes \n");
            codigo = Convert.ToInt16(Console.ReadLine());

            if (codigo == 1)
            {
                precoFinal = preco - (10 * preco / 100);
                Console.WriteLine("\nO preço final do seu produto, com 10% de desconto é R$" + precoFinal);
            }
            else if (codigo == 2)
            {
                precoFinal = preco - (20 * preco / 100);
                Console.WriteLine("\nO preço final do seu produto, com 20% de desconto é R$" + precoFinal);
            }
            else if (codigo == 3)
            {
                precoFinal = preco - (15 * preco / 100);
                Console.WriteLine("\nO preço final do seu produto, com 15% de desconto é R$" + precoFinal);
            }
            else
            {
                Console.WriteLine("\nO preço final do seu produto é R$" + preco);
            }

        }
    }
}
