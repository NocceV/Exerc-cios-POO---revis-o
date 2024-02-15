using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao00_POO_Codigo_professor_Caram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoVetor = 3;

            //delacração das variaveis
            float media;
            string opcao;
            string descricao;

            Produto[] produtos=new Produto[tamanhoVetor]; //criacao da classe produtos

            lervetorProdutos(produtos); 
            media = mediaPrecos(produtos);

            Console.WriteLine("A media do preco dos produtos é igual a: " + media.ToString("0.##"));

            Console.WriteLine("Deseja localizar algum produtos?");
            opcao = (Console.ReadLine()).ToLower();

            if (opcao == "s")
            {
                Console.WriteLine("Qual produto deseja consultar?");
                descricao = Console.ReadLine();

                Produto prod = localizarProduto(descricao, produtos);

                if (prod != null)
                {
                    Console.WriteLine("PRODUTO LOCALIZADO:");
                    Console.WriteLine("Descrição: " + prod.name);
                    Console.WriteLine("Preço unitário: R$ " + prod.preco);

                    Console.WriteLine("Quantos lotes deseja comprar?");
                    int lotes = int.Parse(Console.ReadLine());

                    float total = prod.precoPorLote(lotes);

                    Console.WriteLine("O total que voce ira pagar é: " + total + "R$");
                }
                else
                    Console.WriteLine("Produto não encontrado.");
            }

            Console.ReadLine();

        }

        public static void lervetorProdutos(Produto[] produtos) //ler o nome e o preco dos produtos que o usuario informar, cirando assim um for que cria produtos
        {

            for(int i=0;i<produtos.Length;i++)
            {
                produtos[i] = new Produto();

                Console.WriteLine("Informe a descricao do produto ", i + 1);
                produtos[i].name = Console.ReadLine();

                Console.WriteLine("Informe o valor unitario do produto ", i + 1);
                produtos[i].preco = float.Parse(Console.ReadLine());
            }


        }

        public static float mediaPrecos(Produto[] produtos) //soma a media de todos os produtos
        {
            float soma = somaPrecos(produtos);
            return soma / produtos.Length;

        }

        public static float somaPrecos(Produto[] produtos) //soma todos os precos dos produtos
        {
            float soma = 0;

            for (int i = 0; i< produtos.Length; i++){

                soma += produtos[i].preco;
            }

            return soma;

        }

        public static Produto localizarProduto(string nome, Produto[] produtos) //localiza determinado produto informado
        {
            foreach(Produto item in produtos)
            {
                if (item.name == nome)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
