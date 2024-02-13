using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_27_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um caractere:");
            char caractere = Console.ReadKey().KeyChar;

            if (char.IsLetter(caractere))
            {
                Console.WriteLine("\nÉ uma letra.");
            }
            else if (char.IsDigit(caractere))
            {
                Console.WriteLine("\nÉ um dígito.");
            }
            else if (EhOperadorAritmetico(caractere))
            {
                Console.WriteLine("\nÉ um operador aritmético.");
            }
            else
            {
                Console.WriteLine("\nNão é uma letra, dígito ou operador aritmético.");
            }

            Console.ReadLine();
        }

        static bool EhOperadorAritmetico(char c)
        {
            char[] operadoresAritmeticos = { '+', '-', '*', '/' };
            return Array.IndexOf(operadoresAritmeticos, c) != -1;
        }

    }
}
