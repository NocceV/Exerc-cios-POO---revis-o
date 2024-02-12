using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_17_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetidor = true;

            while(repetidor ==true)
            {

                Console.WriteLine("\nInforme uma mensagem ate 255 caracteres");
                string message=Console.ReadLine();

                if (message.Length <= 255)
                {
                    mostrandoMensagem(message);   
                }
                else
                {
                    repetidor = false;
                }
            }
        }


        public static void mostrandoMensagem(string message)
        {
            for(int i = 0; i < message.Length / 2; i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();
        } 
    }
}
