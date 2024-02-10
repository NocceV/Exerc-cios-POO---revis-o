using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double porcentagem;

                Console.WriteLine("Informe a quantia que você tem a pagar");
                double quantia=double.Parse(Console.ReadLine());

                if(quantia <= 1200)
                {
                    Console.WriteLine("Voce ira pagar: " + quantia);
                }
                else if(quantia <= 5000)
                {
                     porcentagem = (quantia / 100) * 10;
                    Console.WriteLine("Voce ira pagar: " + quantia+porcentagem +", "+ porcentagem+" sendo 10% de imposto e " + quantia +" de valor sem impostos");
                }
                else if(quantia <= 10000)
                {
                     porcentagem = (quantia / 100) * 15;
                     Console.WriteLine("Voce ira pagar: " + quantia + porcentagem + ", " + porcentagem + " sendo 15% de imposto e " + quantia + " de valor sem impostos");
                }
                else{
                    porcentagem = (quantia / 100) * 20;
                     Console.WriteLine("Voce ira pagar: " + quantia + porcentagem + ", " + porcentagem + " sendo 20% de imposto e " + quantia + " de valor sem impostos");
                }

                Console.ReadLine();
            
        }
    }
}
