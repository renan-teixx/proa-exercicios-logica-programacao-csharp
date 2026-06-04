using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex24CalculoDeIMC
    {
        public static void Main(String[] args)
        {

            float peso, altura, imc;

            Console.WriteLine("Calcula o IMC.");

            Console.WriteLine("\nDigite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite sua altura usando casas decimais (Exemplo: 1,75): ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("\nSeu IMC é: " + imc.ToString("F2"));

            if (imc < 18.5)
            {
                Console.WriteLine("\nAbaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("\nNormal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("\nSobrepeso");
            }
            else
            {
                Console.WriteLine("\nObesidade");
            }
        }
    }
}
