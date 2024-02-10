using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primeiro Cria um Laço de repetição 
            //Faz o menu

            bool repetidor = true;

            while (repetidor == true)
            {

                Console.WriteLine("-------Cadastro De Clientes-------");
                Console.WriteLine("0 - FIM");
                Console.WriteLine("1 - Incluir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Consulta");
                Console.WriteLine("4 - Excluir \n Opção: ");

                Console.ReadLine();
            }
        }
    }
}
