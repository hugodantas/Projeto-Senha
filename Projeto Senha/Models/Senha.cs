using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Senha.Models
{
    public class Senha
    {
        public DateTime Emissao { get; set; }
        public TipoServico Servico { get; set; }
        public Guiche GuicheAtendimento { get; set; }
        public int Sequencial { get; set; }
        public bool SenhaNormal { get; set; }
        public StatusSenha Status { get; set; }
        public DateTime InicioAtendimento { get; set; }
        public DateTime FimAtendimento { get; set; }
    }

    public enum StatusSenha
    {
        EmAtendimento,
        Espera,
        Cancelada
    }
}
