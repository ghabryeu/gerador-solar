using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_solar
{
    internal class Produto
    {
        string categoria;
        int id;
        int potencia_em_w;
        string produto_descrito;
        string marca;
        string nome;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Potencia_em_w
        {
            get { return potencia_em_w; }
            set { potencia_em_w = value; }
        }

        public string Produto_descrito
        {
            get { return produto_descrito; }
            set { produto_descrito = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Produto(string categoria, int id, int potencia_em_w, string marca, string nome, string produto_descrito)
        {
            this.Categoria = categoria;
            this.Id = id;
            this.Potencia_em_w = potencia_em_w;
            this.Marca = marca;
            this.Produto_descrito = produto_descrito;
            this.Nome = nome;
        }

        public string CsvString()
        {
            return $"{Categoria},{Id},{Potencia_em_w},{Marca},{Produto_descrito}";
        }

        public static implicit operator string(Produto produto)
            => $"+ {produto.Categoria},{produto.Id},{produto.Potencia_em_w},{produto.Marca},{produto.Produto_descrito}";
    }
}