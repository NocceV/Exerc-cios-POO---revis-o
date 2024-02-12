using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_19_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma data");
            string date = Console.ReadLine();

            for(int i = 0; i < date.Length; i++){

                if (date[i] == '/')
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(date[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
