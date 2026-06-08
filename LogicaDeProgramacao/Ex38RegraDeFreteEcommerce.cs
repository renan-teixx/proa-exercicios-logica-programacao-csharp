using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex38RegraDeFreteEcommerce
    {
        public static void Main(String[] args) 
        {
            float valorCompra;
            int categoriaCliente;

            Console.WriteLine("Calcula o frete do E-commerce.");

            Console.WriteLine("\nDigite o valor da compra: ");
            valorCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o número correspondente a sua categoria (1 - VIP, 2 - Comum): ");
            categoriaCliente = Convert.ToInt16(Console.ReadLine());

            if (categoriaCliente == 1 || (categoriaCliente == 2 && valorCompra > 250))
            {
                Console.WriteLine("\nFrete grátis");
            }
            else 
            {
                Console.WriteLine("\nFrete cobrado");
            }
        }
    }
}
