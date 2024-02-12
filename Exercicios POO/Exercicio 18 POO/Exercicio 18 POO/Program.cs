using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_18_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("POr favor informe seu nome");
            string name = Console.ReadLine();

                Console.Write(name[0]+" ");
            for(int i=0;i < name.Length; i++)
            {
                if (name[i]==' ' && i != name.Length-1)
                {
                    Console.Write(name[i + 1]+" ");
                }
            }

            Console.ReadLine();

        }
    }
}
