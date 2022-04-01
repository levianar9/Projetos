using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projeto_Pizzaria.Cadastro
{
    public partial class FormCliente : Form
    {
        //String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DAcadastrocliente;
        DataSet DScadastrocliente;
        OleDbCommand comInsertPessoa, comUpdatePessoa, comDeletePessoa;
        
        

        public object DAcadastropessoa { get; }

        public FormCliente()
        {
            InitializeComponent();
            //Pega as informações da tabela Cliente e da um Fill (preenchimento)
            string sqlCliente = "select * from CADASTRO_CLIENTE";
            DAcadastrocliente = new OleDbDataAdapter(sqlCliente, ConnStr);
            DScadastrocliente = new DataSet("CADASTRO_CLIENTE");
            DAcadastrocliente.FillSchema(DScadastrocliente, SchemaType.Source);
            DAcadastrocliente.Fill(DScadastrocliente);

            // Preencher DataGridView
            dgCliente.DataSource = DScadastrocliente.Tables[0];

            // Nome Colunas DataGridView
            dgCliente.Columns["codigo"].HeaderText = "Código";
            dgCliente.Columns["nome"].HeaderText = "Nome";
            dgCliente.Columns["endereco"].HeaderText = "E-endereco";
            dgCliente.Columns["bairro"].HeaderText = "bairro";
            dgCliente.Columns["telefone"].HeaderText = "Telefone";


            //Insert 
            string sqlInsert = "insert into CADASTRO_CLIENTE(codigo,nome,endereco,bairro,telefone) values(?,?,?,?,?)";
            comInsertPessoa = new OleDbCommand(sqlInsert);
            comInsertPessoa.Parameters.Add("codigo", OleDbType.Numeric, 9, "codigo");
            comInsertPessoa.Parameters.Add("nome", OleDbType.VarChar, 60, "nome");
            comInsertPessoa.Parameters.Add("endereco", OleDbType.VarChar, 30, "endereco");
            comInsertPessoa.Parameters.Add("bairro", OleDbType.VarChar, 30, "bairro");
            comInsertPessoa.Parameters.Add("telefone", OleDbType.VarChar, 11, "telefone");
            comInsertPessoa.Connection = new OleDbConnection(ConnStr);
            DAcadastrocliente.InsertCommand = comInsertPessoa;

            //Update 
            string sqlUp = "Update CADASTRO_CLIENTE set codigo = ?, nome = ?, endereco = ? , bairro = ? , telefone = ?"; 
            comUpdatePessoa = new OleDbCommand(sqlUp);
            comUpdatePessoa.Parameters.Add("codigo", OleDbType.Numeric, 9, "codigo");
            comUpdatePessoa.Parameters.Add("nome", OleDbType.VarChar, 60, "nome");
            comUpdatePessoa.Parameters.Add("endereco", OleDbType.VarChar, 30, "endereco");
            comUpdatePessoa.Parameters.Add("bairro", OleDbType.VarChar, 30, "bairro");
            comUpdatePessoa.Parameters.Add("telefone", OleDbType.VarChar, 11, "telefone");
            comUpdatePessoa.Connection = new OleDbConnection(ConnStr);
            DAcadastrocliente.UpdateCommand = comUpdatePessoa;

            //Delete
            string sqlDel = "delete from CADASTRO_CLIENTE where codigo = ?";
            comDeletePessoa = new OleDbCommand(sqlDel);
            comDeletePessoa.Parameters.Add(":CODIGO", OleDbType.Numeric, 4, "CODIGO");
            comDeletePessoa.Connection = new OleDbConnection(ConnStr);
            DAcadastrocliente.DeleteCommand = comDeletePessoa;

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar ?" + "\n" + "Todas as informações não salvas serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Clear();
        }

        private void Clear()
        {
            tbCodigo.Clear();
            tbNome.Clear();
            tbEndereco.Clear();
            tbBairro.Clear();
            tbTelefone.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow linha = DScadastrocliente.Tables[0].NewRow();
                linha["codigo"] = tbCodigo.Text;
                linha["nome"] = tbNome.Text;
                linha["endereco"] = tbEndereco.Text;
                linha["bairro"] = tbBairro.Text;
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

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgCliente.CurrentRow.Index;

            tbCodigo.Text = dgCliente["codigo", linha].Value.ToString();
            tbNome.Text = dgCliente["nome", linha].Value.ToString();
            tbEndereco.Text = dgCliente["endereco", linha].Value.ToString();
            tbBairro.Text = dgCliente["bairro", linha].Value.ToString();
            tbTelefone.Text = dgCliente["telefone", linha].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCodigo.Text);
            DataRow reg = DScadastrocliente.Tables[0].Rows.Find(id);
            reg.Delete();
            DAcadastrocliente.Update(DScadastrocliente);

            if (MessageBox.Show("Deseja realmente excluir ?" + "\n" + "Todas as informações serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Clear();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string sqlQ = "select * from CADASTRO_CLIENTE where codigo = '" + tbCodigo.Text + "'";
            DAcadastrocliente.SelectCommand = new OleDbCommand(sqlQ);
            DAcadastrocliente.SelectCommand.Connection = new OleDbConnection(ConnStr);
            DScadastrocliente.Clear();
            DAcadastrocliente.Fill(DScadastrocliente);
            if (DScadastrocliente.Tables[0].Rows.Count > 0)
            {
                DataRow reg = DScadastrocliente.Tables[0].Rows[0];
                tbCodigo.Text = reg["CODIGO"].ToString();
                tbNome.Text = reg["NOME"].ToString();
                tbEndereco.Text = reg["ENDERECO"].ToString();
                tbBairro.Text = reg["BAIRRO"].ToString();
                tbTelefone.Text = reg["TELEFONE"].ToString();
            }
        }

        private void btEdita_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCodigo.Text);
            DataRow reg = DScadastrocliente.Tables[0].Rows.Find(id);
            reg["NOME"] = tbNome.Text;
            reg["ENDERECO"] = tbEndereco.Text;
            reg["BAIRRO"] = tbBairro.Text;
            reg["TELEFONE"] = tbTelefone.Text;
            DAcadastrocliente.Update(DScadastrocliente);

            MessageBox.Show("Cadastro Editado");
            Clear();
        }
    }
}
