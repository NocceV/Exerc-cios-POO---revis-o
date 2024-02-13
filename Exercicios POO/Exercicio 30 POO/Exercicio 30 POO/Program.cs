using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_30_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma dia da semana");
            int dia = int.Parse(Console.ReadLine());

            diadaSemana(dia);
            Console.ReadKey();
        }

        public static void diadaSemana(int dia)
        {
            if (dia == 1)
            {
                Console.WriteLine("É Domingo!");
            }
            else if(dia == 2)
            {
                Console.WriteLine("É Segunda!");
            }
            else if (dia == 3)
            {
                Console.WriteLine("É Terça!");
            }
            else if (dia == 4)
            {
                Console.WriteLine("É Quarta!");
            }
            else if (dia == 5)
            {
                Console.WriteLine("É Quinta!");
            }
            else if (dia == 6)
            {
                Console.WriteLine("É Sexta!");
            }
            else if (dia == 7)
            {
                Console.WriteLine("É Sábado!");
            }
            else
            {
                throw new Exception("Este numero nao corresponde a nenhum dia da semana");
            }

        }
    }
}
