using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Aula_1
{
    public partial class Form1 : Form
    {
        //Conexão com Banco 
        string connStr = "Provider=msdaora;Data Source=LOCAL; User Id=local;Password=local;";
        OleDbDataAdapter daPessoa;
        DataSet dsPessoa;

        public Form1()
        {
            InitializeComponent();

            //Pega as informações da tabela Pessoa e da um Fill (Preenchimento)
            string sqlQ = "select * from CADASTRO_PESSOA";
            daPessoa = new OleDbDataAdapter(sqlQ, connStr);
            dsPessoa = new DataSet("CADASTRO_PESSOA");
            daPessoa.FillSchema(dsPessoa, SchemaType.Source);
            daPessoa.Fill(dsPessoa);

            // Preencher DataGridView
            dgPessoa.DataSource = dsPessoa.Tables[0];

            // Nome Colunas DataGridView
            dgPessoa.Columns["codigo"].HeaderText = "Código";
            dgPessoa.Columns["nome"].HeaderText = "Nome";
            dgPessoa.Columns["email"].HeaderText = "E-mail";
            dgPessoa.Columns["telefone"].HeaderText = "Telefone";

            //Insert
            OleDbCommand comInsert;
            string sqlIns = "insert into CADASTRO_PESSOA (codigo,nome,email,telefone) values (?, ?, ?, ?)";
            comInsert = new OleDbCommand(sqlIns);
            comInsert.Parameters.Add(":CODIGO", OleDbType.Numeric, 6, "CODIGO");
            comInsert.Parameters.Add(":NOME", OleDbType.VarChar, 50, "NOME");
            comInsert.Parameters.Add(":EMAIL", OleDbType.VarChar, 50, "EMAIL");
            comInsert.Parameters.Add(":TELEFONE", OleDbType.Numeric, 11, "TELEFONE");
            comInsert.Connection = new OleDbConnection(connStr);
            daPessoa.InsertCommand = comInsert;

            //Update
            OleDbCommand comUpdate;
            string sqlUp = "update CADASTRO_PESSOA set codigo = ?, nome = ?, email = ? where telefone = ?";
            comUpdate = new OleDbCommand(sqlUp);
            comUpdate.Parameters.Add(":CODIGO", OleDbType.Numeric, 6, "CODIGO");
            comUpdate.Parameters.Add(":NOME", OleDbType.VarChar, 50, "NOME");
            comUpdate.Parameters.Add(":EMAIL", OleDbType.VarChar, 50, "EMAIL");
            comUpdate.Parameters.Add(":TELEFONE", OleDbType.Numeric, 11, "TELEFONE");
            comUpdate.Connection = new OleDbConnection(connStr);
            daPessoa.UpdateCommand = comUpdate;

            //Delete 
            OleDbCommand comDelete;
            string sqlDel = "delete from CADASTRO_PESSOA where codigo = ?";
            comDelete = new OleDbCommand(sqlDel);
            comDelete.Parameters.Add(":CODIGO", OleDbType.Numeric, 6, "CODIGO");
            comDelete.Connection = new OleDbConnection(connStr);
            daPessoa.DeleteCommand = comDelete;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow reg = dsPessoa.Tables[0].NewRow();
                reg["CODIGO"] = tbCodigo.Text;
                reg["NOME"] = tbNome.Text;
                reg["EMAIL"] = tbEmail.Text;
                reg["TELEFONE"] = tbTelefone.Text;
                dsPessoa.Tables[0].Rows.Add(reg);
                daPessoa.Update(dsPessoa);

                MessageBox.Show("Cadastro Realizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {
                MessageBox.Show("Necessário preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            tbCodigo.Clear();
            tbNome.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?" + "\n" + "Todas as informações não salvas serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar?" + "\n" + "Todas as informações não salvas serão perdidas!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Clear();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCodigo.Text);
            DataRow reg = dsPessoa.Tables[0].Rows.Find(id);
            reg["NOME"] = tbNome.Text;
            reg["EMAIL"] = tbEmail.Text;
            reg["TELEFONE"] = tbTelefone.Text;
            daPessoa.Update(dsPessoa);

            MessageBox.Show("Cadastro Atualizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCodigo.Text);
            DataRow reg = dsPessoa.Tables[0].Rows.Find(id);
            reg.Delete();
            daPessoa.Update(dsPessoa);
        }
    }
}
        
    
    

