using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o premio 1");
            string premio1 = Console.ReadLine();

            Console.WriteLine("Informe o premio 2");
            string premio2 = Console.ReadLine();

            string LBV=null;
            bool variante = false;

            for(int i=0;i<premio1.Length;i++)
            {
                if (premio1[i] == '.')
                {
                    variante = true;
                    i++;
                }
                if (variante == true)
                {
                    LBV += premio1[i];
                }

            }

            LBV += ".";
            variante = false;

            for (int i = 0; i < premio2.Length; i++)
            {
                if (premio2[i] == '.')
                {
                    variante = true;
                    i++;
                }
                if (variante == true)
                {
                    LBV += premio2[i];
                }

            }

            Console.WriteLine(LBV);

            Console.ReadLine();
        }
    }
}
