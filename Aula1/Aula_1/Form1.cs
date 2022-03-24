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
    }
}
