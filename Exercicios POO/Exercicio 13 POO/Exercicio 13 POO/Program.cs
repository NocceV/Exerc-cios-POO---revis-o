using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salario do marido");
            double maridoSalario=double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salario da esposa");
            double esposaSalario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe as despesas do marido");
            double maridoDespesa = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe as despesas da esposa");
            double esposaDespesa = double.Parse(Console.ReadLine());


            double despesaTotal = (maridoDespesa + esposaDespesa);

            double porcentagemMarido = porcentagemDeDespesaMarido(maridoSalario, esposaSalario);
            double porcentagemEsposa = 100 - porcentagemMarido;

            double maridoPagou = (despesaTotal / 100) * porcentagemMarido;
            double esposaPagou = despesaTotal - maridoPagou;


            Console.WriteLine("==============================");
            Console.WriteLine("Salario Marido = "+ maridoSalario);
            Console.WriteLine("Porcentagem Marido = "+ porcentagemMarido+"%");
            Console.WriteLine("Marido  Pagou = "+ maridoPagou);
            Console.WriteLine("Saldo = "+ (maridoSalario-maridoPagou));

            Console.WriteLine("==============================");

            Console.WriteLine("Salario Esposa = " + esposaSalario);
            Console.WriteLine("Porcentagem Esposa = " + porcentagemEsposa + "%");
            Console.WriteLine("Esposa  Pagou = " + esposaPagou);
            Console.WriteLine("Saldo = " + (esposaSalario - esposaPagou));

            Console.WriteLine("==============================");
            Console.ReadLine();

        }

        public static double porcentagemDeDespesaMarido(double salarioMarido, double salarioEsposa)
        {
            double total = salarioEsposa + salarioMarido;
            
            double porcentagemMarido = (salarioMarido/total)*100;

            return porcentagemMarido;
        }
    }
}
