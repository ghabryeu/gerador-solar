using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_solar
{
    internal class CriarGerador
    {
        public List<Gerador> CriarGeradores(Estoque estoque)
        {
            var paineis = estoque.BuscarPorCategoria("Painel Solar");
            var inversores = estoque.BuscarPorCategoria("Inversor");
            var controladores = estoque.BuscarPorCategoria("Controlador de Carga");
            var geradores = new List<Gerador>();
            int gerador_id = 10000; // inicializando id dos geradores 

            for (int i = 0; i < paineis.Count; i++)
            {
                for (int j = 0; j < paineis.Count; j++)
                {
                    if (paineis[i].Marca == paineis[j].Marca && paineis[i].Potencia_em_w == paineis[j].Potencia_em_w)
                    {
                        int potencia_total_paineis = paineis[i].Potencia_em_w + paineis[j].Potencia_em_w;

                        foreach (var inversor in inversores)
                        {
                            if (inversor.Potencia_em_w == potencia_total_paineis)
                            {
                                foreach (var controlador in controladores)
                                {
                                    if (controlador.Potencia_em_w == potencia_total_paineis)
                                    {
                                        var gerador = new Gerador
                                        (
                                            (gerador_id++).ToString(),
                                             potencia_total_paineis,
                                             new List<int> { paineis[i].Id, paineis[j].Id, inversor.Id, controlador.Id },
                                             new List<string> { paineis[i].Nome, paineis[j].Nome, inversor.Nome, controlador.Nome },
                                             new List<int> { 1, 1, 1, 1 }
                                        );
                                        geradores.Add(gerador);
                                    }
                                }
                            }
                        }

                    }
                }
            }
            return geradores;
        }
    }
}