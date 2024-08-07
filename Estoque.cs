using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_solar
{
    internal class Estoque
    {
        public List<Produto> Produtos { get; }

        public Estoque()
        {
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public List<Produto> BuscarPorCategoria(string categoria)
        {
            var resultado = new List<Produto>();

            foreach (var produto in Produtos)
            {
                if (produto.Categoria.Equals(categoria))
                {
                    resultado.Add(produto);
                }
            }

            return resultado;
        }
    }
}