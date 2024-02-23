using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Caram_22_02
{
    internal class Hora
    {
        #region Atributos
        /// <summary>
        /// Representa o componente Hora (entre 0 e 23)
        /// </summary>
        public byte hora;
        /// <summary>
        /// Representa o componente Minuto (entre 0 e 59)
        /// </summary>
        public byte minuto;
        /// <summary>
        /// Representa o componente Segundo (entre 0 e 59)
        /// </summary>
        public byte segundo;
        #endregion

        #region Métodos de negócio
        /// <summary>
        /// Faz a validação da hora atribuída. Em caso de hora, minuto ou segundo inválidos, sem reverter o horário em caso de não-validação.
        /// </summary>
        /// <returns>TRUE ou FALSE conforme a hora atual é válida ou não </returns>
        public bool validar()
        {
            bool resposta = false;
            if ((hora >= 0 && hora <= 23) && (minuto >= 0 && minuto <= 59)
                     && (segundo >= 0 && segundo <= 59))
            {
                resposta = true;
            }
            return resposta;
        }

        /// <summary>
        /// Ajusta o horário com os parâmetros passados pelo usuário. Chama o método de validação e, em caso de não-validação, reverte o horário para 00:00:00 (meia noite)
        /// </summary>
        /// <param name="hora">A hora para ser ajustada (0 a 23)</param>
        /// <param name="min">O minuto para ser ajustado (0 a 59)</param>
        /// <param name="seg">O segundo para ser ajustado (0 a 59)</param>
        public void ajustar(byte hora, byte min, byte seg)
        {
            this.hora = hora;
            this.minuto = min;
            this.segundo = seg;
            if (!validar())
            {
                this.hora = this.minuto = this.segundo = 0;
            }
        }
 


        /// <summary>
        /// Retorna uma string com a hora formatada como HH:MM:SS.
        /// </summary>
        /// <returns>String no formato HH:MM:SS</returns>
        public string horaFormatada()
        {
            String horaF = hora.ToString("00");
            String minF = minuto.ToString("00");
            String segF = segundo.ToString("00");

            return horaF + ":" + minF + ":" + segF;

        }


        public bool estahNaFrente(Hora outraHora)
        {
            bool resposta = false;

            int estaHora = segundo + minuto * 60 + segundo * 3600;
            int horaComparada = outraHora.segundo + outraHora.minuto * 60 + outraHora.segundo * 3600;

            if (estaHora > horaComparada)
            {
                return true;
            }


            return resposta;
        }






        public void incrementar(byte valor,char posicao)
        {
            string pos = posicao.ToString();
            pos.ToUpper();

            switch(pos)
        }



        #endregion
    }
}
