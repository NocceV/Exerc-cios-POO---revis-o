using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico_07_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = Math.Sqrt(3);
            
            result= Math.Round(result);

            result = result * result*result;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
