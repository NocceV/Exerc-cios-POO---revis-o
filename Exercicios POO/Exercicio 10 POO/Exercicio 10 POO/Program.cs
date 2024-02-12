using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool repetidor = true;
            double totalPagar = 21.40;

            while (repetidor == true)
            {

                Console.WriteLine("Bem vindo a Vitor Telecom");
                Console.WriteLine("Por favor informe quantas ligações interurbanas voce fez");
                int ligacoesExedentes = int.Parse(Console.ReadLine());

                totalPagar += impulsosAMais(ligacoesExedentes);

              


                Console.WriteLine("Agora informe quantas ligações para celulares voce fez");
                int ligacoesCelular = int.Parse(Console.ReadLine());

                totalPagar += ligCelular(ligacoesCelular);


                Console.WriteLine("O total do mes que voce devera pagar é de :" + totalPagar);
                Console.ReadLine();

            }
        }

        public static double impulsosAMais(int ligacoesExedentes)
        {
            double resultado;
            if (ligacoesExedentes > 90)
            {
                resultado = (ligacoesExedentes - 90) * 0.03;
            }
            else
            {
                resultado = 0;
            }


            return resultado;
        }


        public static double ligCelular(int ligacoesCelular)
        {
            double resultado = ligacoesCelular * 0.40;

            return resultado;

        }
    }
}
