using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pedir a nota do ex 1 e 2
            //calcular o peso das duas notas
            //pedir a nota final
            //pegaro resultado do primeiro calulo mais a notafinal, fazer o devido calculo da media ponderada 
            //retornar a media ponderada do aluno
            bool repetidor = true;

            while (repetidor == true)
            {

                Console.WriteLine("Informe a nota do exercicio 1");
                double exercicioUm = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a nota do exercicio 2");
                double exercicioDois = double.Parse(Console.ReadLine());

                double resultadoExercicio = resultadoExercicios(exercicioUm, exercicioDois);

                Console.WriteLine("Informe o resultado da prova");
                double prova = double.Parse(Console.ReadLine());

                Console.WriteLine("Sua nota final é:" + resultadoFinal(resultadoExercicio,prova).ToString("F"));

            }

            
        }

        public static double resultadoExercicios(double exercicio1,double exercicio2)
        {
            return ((exercicio1 * 1) + (exercicio2 * 2)) / 3;

        }

        public static double resultadoFinal(double resultadoExercicio,double prova)
        {

            return ((resultadoExercicio * 2) + (prova * 8)) / 10;
        }
    }
}
