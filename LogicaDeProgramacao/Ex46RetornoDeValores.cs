using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex46RetornoDeValores
    {
        //Exemplo de método com um parametro de entrada e com um retorno de valor do tipo inteiro.
        /*static int Soma(int numero1) 
        {
            return 5 + numero1;
        }

        public static void Main(String[] args) 
        {
            Console.WriteLine(Soma(3));
        }*/

        //Exemplo de método com dois parametros de entrada e com um retorno do tipo inteiro.
        /*static int Soma(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }

        public static void Main(String[] args) 
        {
            Console.WriteLine(Soma(10, 5));
        }*/

        //Exemplo de método com dois parametros com armazenamento do resultado do tipo inteiro em uma variável de resultado.
        static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(String[] args)
        {
            int resultado = Soma(90, 10);
            Console.WriteLine(resultado);
        }
    }
}
