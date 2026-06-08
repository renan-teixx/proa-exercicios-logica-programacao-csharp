using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex34CriteriosParaDeploy
    {
        public static void Main(String[] args)
        {
            float coberturaTestes;
            bool aprovacaoGestor;
            
            Console.WriteLine("Verifica se o deploy está autorizado ou não.");

            Console.WriteLine("\nDigite a porcentagem de cobertura de testes: ");
            coberturaTestes = float.Parse(Console.ReadLine());

            Console.WriteLine("\nO gestor aprovou? Digite 'true' ou 'false'. ");
            aprovacaoGestor = bool.Parse(Console.ReadLine());

            if (coberturaTestes > 80 || aprovacaoGestor == true)
            {
                Console.WriteLine("\nDeploy autorizado");
            }
            else 
            {
                Console.WriteLine("\nDeploy não autorizado");
            }
        }
    }
}
