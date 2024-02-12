using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe quantas diciplinas voce estuda");
            int numeroDiciplinas = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora informe em minutos totais, quanto tempo de estudo voce tem disponivel?");
            int tempoTotal = int.Parse(Console.ReadLine());

            Console.WriteLine("Voce tem "+tempoPorDiciplina(numeroDiciplinas,tempoTotal)+" de minutos para cada diciplina e "+tempoDescanso(numeroDiciplinas,tempoTotal)+" de minutos de descanso");
            Console.ReadLine();

        }

        public static double tempoPorDiciplina(int numDiciplina,int tempoTotal)
        {

            int tempoPorDic = tempoTotal / numDiciplina;

            return tempoPorDic;
        }

        public static double tempoDescanso(int numDiciplina, int tempoTotal)
        {
            int tempoDescanso = tempoTotal % numDiciplina;

            return tempoDescanso;
        }
    }
}
