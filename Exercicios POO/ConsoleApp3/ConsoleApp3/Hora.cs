using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hora
    {
        /*
        public int hora;
        public int minuto;
        public int segundo;


        public void verificador(Hora horas)
        {
            if (horas.segundo >= 60)
            {
                horas.segundo = horas.segundo - 60;
                horas.minuto += 1;
            }
            if(horas.minuto>= 60)
            {
                horas.minuto=horas.minuto-60;
                horas.hora += 1;
            }
            if(horas.hora >= 24)
            {
                horas.hora = 0;
            }
            

        }

        public void incrementador(Hora hora,int horas,int minutos,int segundos)
        {
            hora.segundo += segundos;
            hora.minuto += minuto;
            hora.hora += horas;
        }

        public void mostarHora(Hora hora)
        {
            string mostar = hora.ToString();
            Console.WriteLine(mostar);
        }

        */

        public int hora;
        public int minuto;
        public int segundo;

        public bool validar()
        {
            bool resposta = false;
            if(hora >=0 && hora <=23  && minuto >=0 && minuto <= 59 && segundo >= 0 && segundo <= 59)
            {
                resposta = true;
            }
            return resposta;
        }

        public void ajustar(int horas,int minutos,int segundos)
        {
            this.hora = horas;
            this.minuto = minutos;
            this.segundo = segundos;

            if (!validar())
            {
                this.hora = this.minuto = this.segundo = 0;
            }
        }

        public string horaFormatada()
        {
            string horaFormatada = hora.ToString("00");
            string minutagemFormatada = minuto.ToString("00");
            string segundoFormatado = segundo.ToString("00");

            return horaFormatada + ":" + minutagemFormatada + ":" + segundoFormatado;
        }

    }
}
