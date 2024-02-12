using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetidor = true;

            while(repetidor== true)
            {

                Console.WriteLine("Pense em um numero");
                int num=int.Parse(Console.ReadLine());

                Console.WriteLine("Multiplique por dois");
                num *= 2;

                Console.WriteLine("Some +6");
                num += 6;

                Console.WriteLine("Agora divida por dois");
                num /= 2;

                Console.WriteLine("Voce pensou no numero " + (num - 3));
                Console.ReadLine();

            }
        }
    }
}
