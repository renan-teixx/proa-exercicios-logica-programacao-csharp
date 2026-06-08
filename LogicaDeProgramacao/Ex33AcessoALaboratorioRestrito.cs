using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex33AcessoALaboratorioRestrito
    {
        public static void Main(String[] args) 
        {
            bool agendamento, presencaProfessor, manutencaoLab;

            Console.WriteLine("Verifica se o aluno pode acessar o laboratório ou não.");

            Console.WriteLine("\nVocê possui agendamento? Digite 'true' ou 'false': ");
            agendamento = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nO professor responsável está presente? Digite 'true' ou 'false': ");
            presencaProfessor = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nO laboratório está em manutenção? Digite 'true' ou 'false': ");
            manutencaoLab = bool.Parse(Console.ReadLine());

            if ((agendamento || presencaProfessor) && manutencaoLab == false)
            {
                Console.WriteLine("\nAcesso autorizado");
            }
            else 
            {
                Console.WriteLine("\nAcesso negado");
            }

        }
    }
}
