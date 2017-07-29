using Projeto_Senha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Senha
{
    public partial class frmTipoServico : Form
    {
        public frmTipoServico()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            TipoServico tipoServico = new TipoServico();
            tipoServico.Nome = txbNome.Text;
            tipoServico.PrefixoSenha = txbPrefixo.Text;

            TipoServico.ServicosDisponiveis.Add(tipoServico);

            var formGuiche = Application.OpenForms["frmGuiche"];
            var componente = (CheckedListBox) formGuiche.Controls[1];
            componente.Items.Add(tipoServico);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            foreach (var servico in TipoServico.ServicosDisponiveis)
            {
                mensagem += servico + "\n";
            }

            MessageBox.Show(mensagem, "Serviços Cadastrados");
        }
    }
}
