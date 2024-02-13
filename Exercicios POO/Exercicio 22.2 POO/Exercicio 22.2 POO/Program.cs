using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_22._2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome da materia");
            string materiaNome = Console.ReadLine();
            Console.WriteLine("Informe sua nota");
            double nota = double.Parse(Console.ReadLine());

            double resultado = resultadoMultiplicacao(nota);

            Console.WriteLine(resultadoFinal(resultado));
            Console.ReadLine();

        }

        public static double resultadoMultiplicacao(double nota)
        {
            return nota * 0.5;
        }

        public static string resultadoFinal(double nota)
        {
            if(nota >= 5)
            {
                return "Aprovado";
            }
            else if(nota >= 4)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        } 
    }
}
