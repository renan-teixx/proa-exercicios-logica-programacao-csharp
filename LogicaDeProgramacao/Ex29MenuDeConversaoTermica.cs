using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex29MenuDeConversaoTermica
    {
        public static void Main(String[] args)
        {

            int opcao;
            float c, f, k;

            Console.WriteLine("Realiza a conversão térmica.");

            Console.WriteLine("\nDigite qual conversão você quer fazer: \n1 - Celsius para Fahrenheit \n2 - Celsius para Kevin \n3 - Fahrenheit para Celsius \n");
            opcao= Convert.ToInt16(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("\nDigite a temperatura em °C: ");
                c = float.Parse(Console.ReadLine());
                f = (c * 9 / 5) + 32;
                Console.WriteLine("\n" + c + "°C equivalem a " + f + "°F");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("\nDigite a temperatura em °C: ");
                c = float.Parse(Console.ReadLine());
                k = c + 273.15f;
                Console.WriteLine("\n" + c + "°C equivalem a " + k + "°K");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\nDigite a temperatura em °F: ");
                f = float.Parse(Console.ReadLine());
                c = (f - 32) * 5 / 9;
                Console.WriteLine("\n" + f + "°F equivalem a " + c + "°C");
            }
            else 
            { 
                Console.WriteLine("\nOpção incorreta");
            }
        }
    }
}