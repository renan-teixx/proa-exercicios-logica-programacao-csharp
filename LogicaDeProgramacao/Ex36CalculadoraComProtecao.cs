using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex36CalculadoraComProtecao
    {
        public static void Main(String[] args) 
        {
            float numero1, numero2, resultado;
            char operacao;

            Console.WriteLine("Calculadora de dois números.");

            Console.WriteLine("\nDigite o primeiro número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o caracter da operação que deseja realizar (+, -, *, /): ");
            operacao = Convert.ToChar(Console.ReadLine());

            if (operacao == '/' && numero2 == 0)
            {
                Console.WriteLine("\nErro: Divisão por zero");
            }
            else if (operacao == '+')
            {
                resultado = numero1 + numero2;
                Console.WriteLine("\nO resultado é: " + resultado);
            }
            else if (operacao == '-')
            {
                resultado = numero1 - numero2;
                Console.WriteLine("\nO resultado é: " + resultado);
            }
            else if (operacao == '*')
            {
                resultado = numero1 * numero2;
                Console.WriteLine("\nO resultado é: " + resultado);
            }
            else if (operacao == '/')
            {
                resultado = numero1 / numero2;
                Console.WriteLine("\nO resultado é: " + resultado);
            }
        }
    }
}
