using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_24_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salario");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe suas horas extras");
            double horasExtras=double.Parse(Console.ReadLine()); 
            if(horasExtras > 0)
            {
                double salarioExtra = horasExetrasValor(horasExtras, salario);
                salario += salarioExtra;
            }

            double INSS = salario / 10;

            Console.WriteLine("Valor liquido = " + salario.ToString("F"));
            Console.WriteLine("Valor com desconto do INSS = " + (salario - INSS).ToString("F"));

            Console.ReadLine();
        }

        public static double horasExetrasValor(double horasExtras,double salario)
        {
            salario /= 176;
            salario *= horasExtras;
            salario *= 1.5;

            return salario;
        }
    }
}
