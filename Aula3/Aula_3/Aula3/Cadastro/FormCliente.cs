using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Aula3.Cadastro
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public object DScadastrocliente { get; private set; }
        public object DAcadastrocliente { get; private set; }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow linha = DScadastrocliente.Tables[0].NewRow();
                linha["nome"] = tbNome.Text;
                linha["cpf"] = tbCPF.Text;
                linha["telefone"] = tbTelefone.Text;

                DScadastrocliente.Tables[0].Rows.Add(linha);
                DAcadastrocliente.Update(DScadastrocliente);

                MessageBox.Show("Cadastro Realizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {
                MessageBox.Show("Necessário preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
