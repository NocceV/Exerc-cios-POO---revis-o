using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horas_Tentativa_de_resoloçãp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hora minhaHora=new Hora();
            Hora outraHora = new Hora();

            minhaHora.ajustarHora(10, 57, 43);
            outraHora.ajustarHora(67, 56, 7);

            Console.WriteLine(minhaHora.mostarHora());
            //Console.WriteLine(outraHora.mostarHora());
            Console.WriteLine(minhaHora.estahNaFrente(outraHora));

            minhaHora.incrementarHora(17, 's');
            Console.WriteLine(minhaHora.mostarHora());

            minhaHora.incrementarHora(10, 'm');
            Console.WriteLine(minhaHora.mostarHora());

            minhaHora.incrementarHora(66, 'h');
            Console.WriteLine(minhaHora.mostarHora());
            Console.ReadLine();

        }
    }
}
