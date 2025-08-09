using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Propriedades
{
    public class Produto
    {
        public string Nome { get; set; } // Leitura e escrita
        public decimal Preco { get; private set; } // Somente leitura pública
        public int Estoque { get; set; }

        public Produto(string nome, decimal preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
