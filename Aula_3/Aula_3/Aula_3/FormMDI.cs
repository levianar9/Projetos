using System;
using Aula_3.Cadastro;
using Aula_3.Processo;
using System.Windows.Forms;

namespace Aula_3
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsCliente_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void tsGenero_Click(object sender, EventArgs e)
        {
            FormGenero frmGenero = new FormGenero();
            frmGenero.MdiParent = this;
            frmGenero.Show();
        }

        private void tsFilme_Click(object sender, EventArgs e)
        {
            FormFilme frmFilme = new FormFilme();
            frmFilme.MdiParent = this;
            frmFilme.Show();
        }

        private void tsLocacao_Click(object sender, EventArgs e)
        {
            FormLocacao frmLocacao = new FormLocacao();
            frmLocacao.MdiParent = this;
            frmLocacao.Show();
        }
    }
}
