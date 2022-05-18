using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Projeto_CRUD_Pessoa
{
    public partial class FormCadPessoa : Form
    {
        // String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DACadPessoa;
        DataSet DSCadPessoa;
        OleDbCommand comInsertPessoa, comUpdatePessoa, comDeletePessoa, comSelectGeral;

        // Variaveis Globais
        bool bControleCadastro = true;
        // true  - Insert
        // false - Uptade

        public FormCadPessoa()
        {
            InitializeComponent();

            // Preenche DATASET
            string sqlPessoa = "SELECT SEQPESSOA,NOME,CPF,DECODE(SEXO,'M','Masculino','Feminino')DESC_SEXO,EMAIL,SEXO FROM CAD_PESSOA";
            DACadPessoa = new OleDbDataAdapter(sqlPessoa, ConnStr);
            DSCadPessoa = new DataSet("CAD_PESSOA");
            DACadPessoa.FillSchema(DSCadPessoa, SchemaType.Source);
            DACadPessoa.Fill(DSCadPessoa);

            // Preenche DataGridView
            dgPessoa.DataSource = DSCadPessoa.Tables[0];

            // Ajusta Nome Colunas DataGridView
            dgPessoa.Columns["nome"].HeaderText = "Nome";
            dgPessoa.Columns["email"].HeaderText = "E-mail";
            dgPessoa.Columns["cpf"].HeaderText = "CPF";
            dgPessoa.Columns["desc_sexo"].HeaderText = "Sexo";

            // Oculta Coluna DataGridView
            dgPessoa.Columns["SEQPESSOA"].Visible = false;
            dgPessoa.Columns["SEXO"].Visible = false;

            // Insert Pessoa
            string sqlInsert = "INSERT INTO CAD_PESSOA(SEQPESSOA,NOME,CPF,SEXO,EMAIL) values(?,?,?,?,?)";
            comInsertPessoa = new OleDbCommand(sqlInsert);
            comInsertPessoa.Parameters.Add("SEQPESSOA", OleDbType.Numeric, 15, "SEQPESSOA");
            comInsertPessoa.Parameters.Add("NOME", OleDbType.VarChar, 100, "NOME");
            comInsertPessoa.Parameters.Add("CPF", OleDbType.Numeric, 11, "CPF");
            comInsertPessoa.Parameters.Add("SEXO", OleDbType.VarChar, 1, "SEXO");
            comInsertPessoa.Parameters.Add("EMAIL", OleDbType.VarChar, 100, "EMAIL");
            comInsertPessoa.Connection = new OleDbConnection(ConnStr);
            DACadPessoa.InsertCommand = comInsertPessoa;

            // Update Pessoa
            string sqlUpdate = "UPDATE CAD_PESSOA SET NOME = ?, CPF = ?, SEXO = ?, EMAIL = ? where SEQPESSOA = ?";
            comUpdatePessoa = new OleDbCommand(sqlUpdate);
            comUpdatePessoa.Parameters.Add(":NOME", OleDbType.VarChar, 100, "NOME");
            comUpdatePessoa.Parameters.Add(":CPF", OleDbType.Numeric, 11, "CPF");
            comUpdatePessoa.Parameters.Add(":SEXO", OleDbType.VarChar, 1, "SEXO");
            comUpdatePessoa.Parameters.Add(":EMAIL", OleDbType.VarChar, 100, "EMAIL");
            comUpdatePessoa.Parameters.Add(":SEQPESSOA", OleDbType.Numeric, 15, "SEQPESSOA"); // CHAVE PRIMARIA TABELA PESSOA
            comUpdatePessoa.Connection = new OleDbConnection(ConnStr);
            DACadPessoa.UpdateCommand = comUpdatePessoa;

            // Delete Pessoa
            string sqlDelete = "DELETE FROM CAD_PESSOA WHERE SEQPESSOA = ?";
            comDeletePessoa = new OleDbCommand(sqlDelete);
            comDeletePessoa.Parameters.Add(":SEQPESSOA", OleDbType.Numeric, 15, "SEQPESSOA");
            comDeletePessoa.Connection = new OleDbConnection(ConnStr);
            DACadPessoa.DeleteCommand = comDeletePessoa;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (bControleCadastro)
            {
                // Busca SEQPESSOA através da sequence S_CAD_PESSOA 
                string sqlSequenceCliente = "SELECT S_CAD_PESSOA.NEXTVAL FROM DUAL";
                comSelectGeral = new OleDbCommand(sqlSequenceCliente);
                comSelectGeral.Connection = new OleDbConnection(ConnStr);
                comSelectGeral.Connection.Open();
                int SeqPessoa = int.Parse(comSelectGeral.ExecuteScalar().ToString());

                try
                {
                    DataRow insert = DSCadPessoa.Tables[0].NewRow();
                    insert["SEQPESSOA"] = SeqPessoa;
                    insert["NOME"] = tbNome.Text;
                    insert["CPF"] = tbCPF.Text.Replace(",", "").Replace("-", "");
                    insert["SEXO"] = RetornaSexo();
                    insert["EMAIL"] = tbEmail.Text;

                    DSCadPessoa.Tables[0].Rows.Add(insert);
                    DACadPessoa.Update(DSCadPessoa);

                    Clear(); // Limpa Campos
                    DACadPessoa.Fill(DSCadPessoa); // Atualiza DataGrid
                    MessageBox.Show("Cadastrad realizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Necessário preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DataRow update = DSCadPessoa.Tables[0].Rows.Find(tbSeqPessoa.Text);
                    update["NOME"] = tbNome.Text;
                    update["CPF"] = tbCPF.Text.Replace(",", "").Replace("-", "");
                    update["SEXO"] = RetornaSexo();
                    update["EMAIL"] = tbEmail.Text;
                    DACadPessoa.Update(DSCadPessoa);

                    Clear(); // Limpa Campos
                    DACadPessoa.Fill(DSCadPessoa); // Atualiza DataGrid
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao atualizar cadastro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retorna dados do DataGrid para os campos ao clicar na linha
            int linha = dgPessoa.CurrentRow.Index;

            tbSeqPessoa.Text = dgPessoa["seqpessoa", linha].Value.ToString();
            tbNome.Text = dgPessoa["nome", linha].Value.ToString();
            tbCPF.Text = dgPessoa["cpf", linha].Value.ToString();
            tbEmail.Text = dgPessoa["email", linha].Value.ToString();
            
            string sexo = dgPessoa["desc_sexo", linha].Value.ToString();
            if (sexo == "Masculino")
                rbMasculino.Checked = true;
            else
                rbFeminino.Checked = true;

            bControleCadastro = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int excluir = int.Parse(tbSeqPessoa.Text);
            DataRow reg = DSCadPessoa.Tables[0].Rows.Find(excluir);
            reg.Delete();
            DACadPessoa.Update(DSCadPessoa);

            Clear(); // Limpa Campos
            DACadPessoa.Fill(DSCadPessoa); // Atualiza DataGrid
            MessageBox.Show("Cadastro excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?" + "\n" + "Todas as informações não salvas serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        // Metodo criado para limpar os campos
        public void Clear()
        {
            tbNome.Clear();
            tbCPF.Clear();
            tbEmail.Clear();
            rbMasculino.Checked = true;
            
            // Seta cursor no primeiro campo da tela
            tbNome.Focus();

            bControleCadastro = true;
        }

        public string RetornaSexo()
        {
            if (rbMasculino.Checked)
                return "M";
            else
                return "F";
        }
    }
}
