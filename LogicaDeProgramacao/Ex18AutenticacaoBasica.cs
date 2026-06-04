using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex18AutenticacaoBasica
    {
        public static void Main(String[] args)
        {

            string nome, senha;

            Console.WriteLine("Libera o acesso caso seu nome e senha estejam corretos.");

            Console.WriteLine("\nDigite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("\nDigite sua senha");
            senha = Console.ReadLine();

            if (nome == "admin" && senha == "12345") 
            { 
            
                Console.WriteLine("\nAcesso liberado");

            }
            else 
            { 
                
                Console.WriteLine("\nCredenciais inválidas");
            
            }

        }
    }
}
