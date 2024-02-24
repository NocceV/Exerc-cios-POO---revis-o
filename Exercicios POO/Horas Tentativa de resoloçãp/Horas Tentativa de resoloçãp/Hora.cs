using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Horas_Tentativa_de_resoloçãp
{
    internal class Hora
    {
        #region Atributos

        /// <summary>
        ///     Representa as Horas (de 00 até 23)
        /// </summary>
        public byte hora;
        /// <summary>
        ///    Representa os minutos (de 00 até 59)
        /// </summary>
        public byte minuto;
        /// <summary>
        /// Representa os segundos(de 00 ate 59)
        /// </summary>
        public byte segundo;

        #endregion

        #region Métodos


        /// <summary>
        /// Metodo que verifica se as horas , minutos e segundos são validos na determinada hora. 
        /// </summary>
        /// <returns>TRUE caso a hora esteja válida, FALSE caso tenha algum horario ultrapassando os limites estabelecidos</returns>
        public bool validarHorario()
        {
            bool resposta = false;

            if((hora<=23 && hora >= 00 ) && (minuto >=0 && minuto<=59) && (segundo >= 0 && segundo <= 59)){

                resposta = true;
            
            }


            return resposta;

        }

        /// <summary>
        ///    Compara  hora passada por parametro com a hora que "requisitou" seu metodo.
        /// </summary>
        /// <param name="horaComparada">Objeto "Hora" que será comparado  passado por parametro </param>
        /// <returns>TRUE Se a hora que requisitou for maior, FALSE se a hora que requisitou o método for menor</returns>
        public bool estahNaFrente(Hora horaComparada)
        {
            bool resposta = false;
            int horaExterna = horaComparada.hora + horaComparada.minuto * 60 + horaComparada.segundo * 3600;
            int minhaHora=hora+minuto*60+segundo*3600;

            if (minhaHora > horaExterna)
            {
                resposta = true;
                return resposta;
            }

            return resposta;
        }



        /// <summary>
        /// Converte os atributos para um formato de string 
        /// </summary>
        /// <returns> Retorna uma string informando as horas</returns>
        public string mostarHora()
        {
            string horaStr = this.hora.ToString("00");
            string minutoStr = this.minuto.ToString("00");
            string segundoStr = this.segundo.ToString("00");

            return horaStr + ":" + minutoStr + ":" + segundoStr;
           
        }

        /// <summary>
        /// Meotodo que ajusta a hora/(atributos) com os parametros passados, logo depois valida a hora. Se estiver returnar true,
        /// as horas sao ajustadas como planejado, se não der e o metodo "validarHora()" retornar false, então todos os atributos são setados como 0,
        /// reiniciando as horas.
        /// </summary>
        /// <param name="hora"> refere-se a hora</param>
        /// <param name="minuto">refere-se aos minutos</param>
        /// <param name="segundo">refere-se aos segundos</param>
        public void ajustarHora(byte hora,byte minuto,byte segundo)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;

            if (validarHorario() == false)
            {
                this.hora = 0;
                this.minuto = 0;
                this.segundo = 0;
            }
        }

        /// <summary>
        /// Metodo que recebe um valor a ser incrementado e a posição deste valor.
        /// O metodo incrementa o valor passado na sua respectiva posição.
        /// Logo após ele "chama" um outro metodo "configurarIncremento" que irá balancear o horário com o objetivo de deixa-lo correto
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="atributo"></param>
        /// <exception cref="Exception"></exception>
        public void incrementarHora(byte valor, char atributo)
        {
            string posicaoAtributo = atributo.ToString().ToUpper();

            switch (posicaoAtributo)
            {
                case "S":
                    this.segundo += valor;
                    break;
                case "M":
                    this.minuto += valor;
                    break;
                case "H":
                    this.hora += valor;
                    break;
                default:
                    throw new Exception("Posição passada inválida");
            }

            configurarIncremento();
        }


        /// <summary>
        /// Metodo que ajusta a hora depois dela se incrementada, deixando ela totalmente correta e dentro dos padrões
        /// </summary>
        /// 
        public void configurarIncremento()
        {
            if (this.segundo >= 60)
            {
                int novoMinuto = this.segundo / 60;
                int segundosReais = this.segundo % 60;

                this.segundo = (byte)segundosReais;
                this.minuto += (byte)novoMinuto;

            }
            if (this.minuto >= 60)
            {
                int novaHora= this.minuto / 60;
                int minutosReais = this.minuto % 60;

                this.minuto = (byte)minutosReais;
                this.hora += (byte)novaHora;

            }
            if(this.hora >= 24)
            {
               int horaReal = this.hora % 24;
                hora= (byte)horaReal;
            }

        }




        #endregion
    }
}
