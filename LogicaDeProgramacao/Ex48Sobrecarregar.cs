using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex48Sobrecarregar
    {
        static int Soma(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }

        static double Soma(double numero1, double numero2)
        {
            return numero1 + numero2; 
        }

        public static void Main(String[] args) 
        {
            int resultadoInt = Soma(8, 5);
            double resultadoDouble = Soma(4.74, 6.26);

            Console.WriteLine("Resultado da soma dos inteiros: " + resultadoInt);
            Console.WriteLine("Resultado da soma dos números com casas decimais: " + resultadoDouble);
        }
    }
}
