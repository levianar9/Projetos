using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aula_1
{
    public partial class Form1 : Form
    {
        //String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DAcadastropessoa;
        DataSet DScadastropessoa;
        OleDbCommand comInsertPessoa;
        OleDbCommand comUpdatePessoa;
        OleDbCommand comDeletePessoa;

        public Form1()
        {
            InitializeComponent();
            //Pega as informações da tabela Pessoa e da um FIll (preenchimento)
            string sqlPessoa = "select * from CADASTROPESSOA";
            DAcadastropessoa = new OleDbDataAdapter(sqlPessoa, ConnStr);
            DScadastropessoa = new DataSet("CADASTROPESSOA");
            DAcadastropessoa.FillSchema(DScadastropessoa, SchemaType.Source);
            DAcadastropessoa.Fill(DScadastropessoa);

            // Insert Pessoa 
            string sqlInsert = "insert into CADASTROPESSOA(codigo,nome,email,telefone) values(?,?,?,?)";
            comInsertPessoa = new OleDbCommand(sqlInsert);
            comInsertPessoa.Parameters.Add("codigo", OleDbType.Numeric, 6, "codigo");
            comInsertPessoa.Parameters.Add("nome", OleDbType.VarChar, 100, "nome");
            comInsertPessoa.Parameters.Add("email", OleDbType.VarChar, 100, "email");
            comInsertPessoa.Parameters.Add("telefone", OleDbType.VarChar, 11, "telefone");
            comInsertPessoa.Connection = new OleDbConnection(ConnStr);
            DAcadastropessoa.InsertCommand = comInsertPessoa;

            // Editar Pessoa
            string sqlUp = "update CADASTROPESSOA set codigo = ?, nome = ?, email = ? where telefone = ?";
            comUpdatePessoa = new OleDbCommand(sqlUp);
            comUpdatePessoa.Parameters.Add(":CODIGO", OleDbType.Numeric, 6, "CODIGO");
            comUpdatePessoa.Parameters.Add(":NOME", OleDbType.VarChar, 100, "NOME");
            comUpdatePessoa.Parameters.Add(":EMAIL", OleDbType.VarChar, 100, "EMAIL");
            comUpdatePessoa.Parameters.Add(":TELEFONE", OleDbType.VarChar, 11, "TELEFONE");
            comUpdatePessoa.Connection = new OleDbConnection(ConnStr);
            DAcadastropessoa.UpdateCommand = comUpdatePessoa;

            // Excluir Pessoa 
            string sqlDel = "delete from CADASTROPESSOA where codigo = ?";
            comDeletePessoa = new OleDbCommand(sqlDel);
            comDeletePessoa.Parameters.Add(":CODIGO", OleDbType.Numeric, 4, "CODIGO");
            comDeletePessoa.Connection = new OleDbConnection(ConnStr);
            DAcadastropessoa.DeleteCommand = comDeletePessoa;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DataRow linha = DScadastropessoa.Tables[0].NewRow();
            linha["codigo"] = tbCodigo.Text;
            linha["nome"] = tbNome.Text;
            linha["email"] = tbEmail.Text;
            linha["telefone"] = tbTelefone.Text;

            DScadastropessoa.Tables[0].Rows.Add(linha);
            DAcadastropessoa.Update(DScadastropessoa);

            MessageBox.Show("Cadastro Realizado");
            Clear();
        }
        public void Clear()
        {
            tbCodigo.Clear();
            tbNome.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
        }

        private void tbEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCodigo.Text);
            DataRow reg = DScadastropessoa.Tables[0].Rows.Find(id);
            reg["NOME"] = tbNome.Text;
            reg["EMAIL"] = tbEmail.Text;
            reg["TELEFONE"] = tbTelefone.Text;
            DAcadastropessoa.Update(DScadastropessoa);

            MessageBox.Show("Cadastro Editado");
            Clear();
        }

        private void tbExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCodigo.Text);
            DataRow reg = DScadastropessoa.Tables[0].Rows.Find(id);
            reg.Delete();
            DAcadastropessoa.Update(DScadastropessoa);

            MessageBox.Show("Cadastro Excluído");
            Clear();
        }

        private void tbBuscar_Click(object sender, EventArgs e)
        {
            string sqlQ = "select * from CADASTROPESSOA where codigo = '" + tbCodigo.Text + "'";
            DAcadastropessoa.SelectCommand = new OleDbCommand(sqlQ);
            DAcadastropessoa.SelectCommand.Connection = new OleDbConnection(ConnStr);
            DScadastropessoa.Clear();
            DAcadastropessoa.Fill(DScadastropessoa);
            if (DScadastropessoa.Tables[0].Rows.Count > 0)
            {
                DataRow reg = DScadastropessoa.Tables[0].Rows[0];
                tbCodigo.Text = reg["CODIGO"].ToString();
                tbNome.Text = reg["NOME"].ToString();
                tbEmail. Text = reg["EMAIL"].ToString();
                tbTelefone.Text = reg["TELEFONE"].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    
    

