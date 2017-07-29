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
    public partial class frmGuiche : Form
    {
        public frmGuiche()
        {
            InitializeComponent();
        }

        public CheckedListBox GetComponent()
        {
            return clbServicos;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Guiche guiche = new Guiche();
            guiche.Numero = txbCodigo.Text;
            guiche.TiposServicosAtendidos = new List<TipoServico>();
            foreach (var item in clbServicos.SelectedItems)
            {
                guiche.TiposServicosAtendidos.Add(item as TipoServico);
            }

            Guiche.GuichesCadastrados.Add(guiche);

            MessageBox.Show("Guichê cadastrado com sucesso.");
        }

        private void btnExibirCadastrados_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            foreach (var item in Guiche.GuichesCadastrados)
            {
                mensagem += item.ToString();
                mensagem += "\n";
            }

            MessageBox.Show(mensagem, "Guichês cadastrados");
        }

        private void frmGuiche_Load(object sender, EventArgs e)
        {
            var tipoServico = new frmTipoServico();
            tipoServico.Show();
        }
    }
}
