using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_23_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quants aulas foram ministradas");
            double quantAulas=double.Parse(Console.ReadLine());

            Console.WriteLine("Informe quants aulas o aluno foi");
            double aulasParticipadas = double.Parse(Console.ReadLine());

            if((quantAulas/aulasParticipadas)*100 >= 75)
            {
                Console.WriteLine("Aprovado ");
            }
            else{

                Console.WriteLine("Reprovado");
            }

            Console.ReadKey();
        }
    }
}
