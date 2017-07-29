using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Senha.Models
{
    public class Guiche
    {
        public static List<Guiche> GuichesCadastrados = new List<Guiche>();

        public string Numero { get; set; }
        public List<TipoServico> TiposServicosAtendidos { get; set; }

        public string TipoServicos
        {
            get
            {
                string servicos = "";
                foreach (var servico in TiposServicosAtendidos)
                {
                    if (string.IsNullOrWhiteSpace(servicos))
                        servicos += ",";

                    servicos += servico.Nome;
                }

                return servicos;
            }
        }

        public override string ToString()
        {
            return $"Caixa número: {Numero}. Tipos de Serviços: {TipoServicos}";
        }
    }
}
