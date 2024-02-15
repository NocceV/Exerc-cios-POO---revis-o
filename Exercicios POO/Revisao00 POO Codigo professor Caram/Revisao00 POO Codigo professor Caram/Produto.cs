using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao00_POO_Codigo_professor_Caram
{
    internal class Produto
    {
        public string name;
        public float preco;

        public float precoPorLote(int quantidade)
        {
            return quantidade * preco;
        }
    }
}
