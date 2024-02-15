using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Hora horario1 = new Hora();

            Console.WriteLine("Informe as horas");
            Console.WriteLine("Pirmeiramente informe as horas");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora informe os minutos");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Por fim informe os segundos");
            int segundos = int.Parse(Console.ReadLine());

            horario1.hora = horas;
            horario1.minuto = minutos;
            horario1.segundo = segundos;

            */

            Hora minhaHora=new Hora();

            minhaHora.ajustar(20, 46, 05);

            Console.WriteLine(minhaHora.horaFormatada());

            Console.ReadLine();



        }
    }
}
