using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Conta é criada
            Conta minhaConta= new Conta();

            //Limite é definido
            minhaConta.definirLimite(100);

            //Primeiro depósito feito, seguido da impressão do saldo atual.
            minhaConta.depositar(200);
            Console.WriteLine(minhaConta.verSaldoAtual());

            //Primeiro saque feito, seguido da impressão do saldo atual.
            minhaConta.sacar(300);
            Console.WriteLine(minhaConta.verSaldoAtual());

            //Deposito de 100 reais, seguido de impressão do saldo atual.
            minhaConta.depositar(100);
            Console.WriteLine(minhaConta.verSaldoAtual());

            //Visualização do histórico de transações
            minhaConta.verExtrato();

            //Depositos e saques feitos para demonstração do funcionamento do histórico de transações
            minhaConta.depositar(1);
            minhaConta.depositar(23);
            minhaConta.depositar(2);
            minhaConta.depositar(240);
            minhaConta.sacar(200);
            minhaConta.sacar(20);
            minhaConta.sacar(50);


            Console.WriteLine(minhaConta.verSaldoAtual());
            minhaConta.verExtrato();

            minhaConta.depositar(2);
            minhaConta.verExtrato();

            Console.ReadLine();
        }
    }
}
