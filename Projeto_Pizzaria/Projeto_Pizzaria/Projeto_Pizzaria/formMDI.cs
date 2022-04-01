using Projeto_Pizzaria.Cadastro;
using Projeto_Pizzaria.Venda;
using System;
using System.Windows.Forms;


namespace Projeto_Pizzaria
{
    public partial class formMDI : Form
    {
        public formMDI()
        {
            InitializeComponent();
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void tsCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void tsTipo_Click(object sender, EventArgs e)
        {
            FormTipo formTipo = new FormTipo();
            formTipo.MdiParent = this;
            formTipo.Show();
        }

        private void tsSabores_Click(object sender, EventArgs e)
        {
            FormSabor formSabor = new FormSabor();
            formSabor.MdiParent = this;
            formSabor.Show();
        }

        private void tsPedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.MdiParent = this;
            formPedido.Show();
        }
    }
}
