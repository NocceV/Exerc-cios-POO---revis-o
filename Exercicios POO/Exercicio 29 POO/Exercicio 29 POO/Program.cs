using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_29_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato 'DD/MM/AAAA':");
            string inputData = Console.ReadLine();

            if (ValidarFormatoData(inputData))
            {
                Console.WriteLine("Formato de data correto.");

                string[] partesData = inputData.Split('/');
                int dia = int.Parse(partesData[0]);
                int mes = int.Parse(partesData[1]);
                int ano = int.Parse(partesData[2]);

                if (ValidarDia(dia) && ValidarMes(mes))
                {
                    Console.WriteLine("Data válida: {0}/{1}/{2}", dia, mes, ano);
                }
            }
            else
            {
                Console.WriteLine("Formato de data incorreto. Use 'DD/MM/AAAA'.");
            }

            Console.ReadLine();
        }

        static bool ValidarFormatoData(string data)
        {
           
            return System.Text.RegularExpressions.Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
        }

        static bool ValidarDia(int dia)
        {
            
            if (dia >= 1 && dia <= 31)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Erro: O dia deve estar entre 1 e 31.");
                return false;
            }
        }

        static bool ValidarMes(int mes)
        {
           
            if (mes >= 1 && mes <= 12)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Erro: O mês deve estar entre 1 e 12.");
                return false;
            }
        }

    }

    }

