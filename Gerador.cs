using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_solar
{
    internal class Gerador
    {
        public string Id_gerador { get; set; }
        public int Potencia_gerador { get; set; }
        public List<int> Id_produto { get; set; }
        public List<string> Nome_produto { get; set; }
        public List<int> Quantidade_produto { get; set; }

        public Gerador(string id_gerador, int potencia_gerador, List<int> id_produto, List<string> nome_produto, List<int> quantidade_produto)
        {
            this.Id_gerador = id_gerador;
            this.Potencia_gerador = potencia_gerador;
            this.Id_produto = id_produto;
            this.Nome_produto = nome_produto;
            this.Quantidade_produto = quantidade_produto;
        }
    }
}
