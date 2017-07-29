using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Senha.Models
{
    public class TipoServico
    {
        public static List<TipoServico> ServicosDisponiveis = new List<TipoServico>();

        public string Nome { get; set; }
        public string PrefixoSenha { get; set; }

        public static void AdicionarServico(TipoServico tipoServico)
        {
            ServicosDisponiveis.Add(tipoServico);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Prefixo da senha: {PrefixoSenha}";
        }
    }
}
