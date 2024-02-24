using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1_POO
{
    internal class Conta
    {
        #region Atributos


        public string CPF;
        public int numeroConta;
        public int saldoAtual;
        public int limite;
        public Queue<int> extrato=new Queue<int>();
        #endregion


        #region Metodos


        /// <summary>
        /// Este metodo define o valor do atributo limite.
        /// O ideal seria o limite ser definido pelo banco, 
        /// porem aqui só seria um exemplo de como este atributo seria usado
        /// </summary>
        /// <param name="limite"> Parametro do valor que o limite vai ter</param>
        public void definirLimite(int limite)
        {
            this.limite=limite;
        }

        /// <summary>
        /// Metodo com a responsabilidade de depositar na conta um valor parssado por parametro
        /// Se o "saldoAtual" for >= 0, este o valor so é depositaod.
        /// Caso contrário, um valor de juros é cobrado pelo banco e retirado do valor depositado
        /// </summary>
        /// <param name="valor"></param>
        public void depositar(int valor)
        {
            if (this.saldoAtual >= 0)
            {
                this.saldoAtual += valor;
                adicionarExtrato(valor);
            }
            else
            {
                double juros = (Math.Abs(saldoAtual)/100) * 3;
                this.saldoAtual += valor-(int)juros;
                adicionarExtrato(valor - (int)juros);
                
            }
        }

        /// <summary>
        /// Retorna o valor do atributo "saldoAtual"
        /// </summary>
        /// <returns>Retorno do saldoAtual</returns>
        public string verSaldoAtual()
        {
            return "R$ "+saldoAtual.ToString("F"); 
        }

        /// <summary>
        /// Metodo responsavel por retirar um determinado valor do "saldoAtual", contando também com o limite estabelecido
        /// </summary>
        /// <param name="valor">Valor a ser sacado</param>
        /// <returns>Se o valor é realmente sacado, então o metodo retorna true</returns>
        /// <exception cref="Exception">Caso o valor não possa ser sacado, uma exceção é executada</exception>
        public bool sacar(int valor)
        {
            if ((this.saldoAtual + this.limite) >= valor){

                saldoAtual -= valor;
                adicionarExtrato(valor*-1);
                return true;
            
            }
            else
            {
                throw new Exception("Saldo atual insuficiente para saques de valor: R$" + valor.ToString("F"));
            }

        }

        /// <summary>
        /// Metodo que é acionado quando qualquer ação de sacar ou depositar é feita.
        /// Após ser acionado este método adiciona a uma fila de histórico o valor que foi sacado ou depositado.
        /// A fila aceita somente até as ultimas 10 ações feitas, ao passar deste número, a ação mais antiga é "apagada".  
        /// </summary>
        /// <param name="valor">Valor que foi sacado ou depositado</param>
        public void adicionarExtrato(int valor)
        {
            extrato.Enqueue(valor);
            if (this.extrato.Count() > 10)
            {
                extrato.Dequeue();
            }
           
        }
        
        /// <summary>
        /// Método que imprime  os 10 últimos  extratos.
        /// </summary>
        public void verExtrato()
        {
            int[] extratoVetor = extrato.ToArray();
            int tamanhoHistorico = extrato.Count();

            Console.WriteLine("\nHistórico de extrato: ");

            for (int i = 0; i < tamanhoHistorico; i++)
            {
                Console.Write(extratoVetor[i]+", ");
            }
            Console.WriteLine();
        }

        #endregion


    }
}
