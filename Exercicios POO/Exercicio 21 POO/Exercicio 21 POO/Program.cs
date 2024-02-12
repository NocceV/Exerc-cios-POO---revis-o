using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_21_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero 3");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;

            if (num2 > maior)
            {
                maior = num2;
            }
            if (num3 > maior)
            {
                maior = num3;
            }

            Console.WriteLine("O maior numero é o " + maior);
            Console.ReadLine();
        }
    }
}
