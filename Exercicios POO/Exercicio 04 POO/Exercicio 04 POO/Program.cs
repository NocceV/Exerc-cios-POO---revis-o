using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cinco = 500, Quatro = 400, Tres = 300;


            Console.WriteLine("Com madeiras de 5 Metros o marceneiro consegue fazer " + Cinco/45 + "pedaços de tábuas e sobrará " + Cinco%45 + " centimetros de tábua\n");
            Console.WriteLine("Com madeiras de 4 Metros o marceneiro consegue fazer " + Quatro/45 + "pedaços de tábuas e sobrará " + Quatro%45 + " centimetros de tábua\n");
            Console.WriteLine("Com madeiras de 3 Metros o marceneiro consegue fazer " + Tres/45 + "pedaços de tábuas e sobrará " + Tres%45 + " centimetros de tábua\n");

            Console.ReadLine();
        }
    }
}
