using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos metros a casa tem em largura");
            double largura = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Agora informe quantos metros em comprimento a casa tem");
            double comprimento = double.Parse(Console.ReadLine());
            

            double resultado=pitagoras(comprimento, largura);
           

            Console.WriteLine("O comprimento do fio sera de "+ resultado +" metros");
            Console.ReadLine();

        }

        public static double pitagoras(double comprimento, double largura)
        {

            double resultado=(comprimento*comprimento)+(largura*largura);
            resultado = Math.Sqrt(resultado);
            return resultado;
        }
    }
}
