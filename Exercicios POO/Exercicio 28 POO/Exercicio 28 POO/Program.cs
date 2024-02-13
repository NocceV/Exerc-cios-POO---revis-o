using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_28_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salario");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("O total a pagar sera de " + impostoAPagar(salario));

            Console.ReadLine();
        }

        public static string impostoAPagar(double salario)
        {
            double imposto;
            if(salario > 1200)
            {
                imposto = (salario / 100)*10;
                return (imposto + salario).ToString();
            }
            else if(salario > 2500)
            {
                imposto = (salario / 100) * 15;
                return (imposto + salario).ToString();
            }
            else if(salario > 5000)
            {
                imposto = (salario / 100) * 20;
                return (imposto + salario).ToString();
            }
            else
            {
                
                return  salario.ToString();
            }
        }
    }
}
