using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex20DescontoDeMaterialDidatico
    {
        public static void Main(String[] args)
        {

            float compra, compraComDesconto;

            Console.WriteLine("Aplica desconto de 10% caso sua compra de livros seja superior a R$200.00");

            Console.WriteLine("\nDigite o valor da sua compra de livros: ");
            compra = float.Parse(Console.ReadLine());

            if (compra > 200)
            {
                compraComDesconto = compra - (10 * compra / 100);
                Console.WriteLine("\nO valor da sua compra com desconto é R$" + compraComDesconto);

            }
            else 
            {

                Console.WriteLine("\nNão houve desconto, o valor da sua compra é R$" + compra); 
            
            }

        }
    }
}
