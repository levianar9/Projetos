using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aula_3.Cadastro
{
    public partial class FormCliente : Form
    {
        // String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DACliente;
        DataSet DSCliente;
        OleDbCommand comInsertCliente, comSelectGeral;

        private void btIncluir_Click(object sender, EventArgs e)
        {
            // Busca SEQCLIENTE 
            string sqlSequenceCliente = "SELECT S_LOC_CLIENTE.NEXTVAL FROM DUAL";
            comSelectGeral = new OleDbCommand(sqlSequenceCliente);
            comSelectGeral.Connection = new OleDbConnection(ConnStr);
            comSelectGeral.Connection.Open();
            int SeqCliente = int.Parse(comSelectGeral.ExecuteScalar().ToString());

            try
            {
                DataRow linha = DSCliente.Tables[0].NewRow();
                linha["SEQCLIENTE"] = SeqCliente;
                linha["NOME"] = tbNome.Text;
                linha["CPF"] = tbCPF.Text.Replace(",", "").Replace("-", "");
                linha["TELEFONE"] = tbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");

                DSCliente.Tables[0].Rows.Add(linha);
                DACliente.Update(DSCliente);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {
                MessageBox.Show("Necessário preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Clear()
        {
            tbNome.Clear();
            tbCPF.Clear();
            tbTelefone.Clear();
        }

        public FormCliente()
        {
            InitializeComponent();

            string sqlPessoa = "SELECT * FROM LOC_CLIENTE";
            DACliente = new OleDbDataAdapter(sqlPessoa, ConnStr);
            DSCliente = new DataSet("LOC_CLIENTE");
            DACliente.FillSchema(DSCliente, SchemaType.Source);
            DACliente.Fill(DSCliente);

            // Insert Cliente
            string sqlInsert = "INSERT INTO LOC_CLIENTE(SEQCLIENTE,NOME,CPF,TELEFONE) values(?,?,?,?)";
            comInsertCliente = new OleDbCommand(sqlInsert);
            comInsertCliente.Parameters.Add("SEQCLIENTE", OleDbType.Numeric, 9, "SEQCLIENTE");
            comInsertCliente.Parameters.Add("NOME", OleDbType.VarChar, 60, "NOME");
            comInsertCliente.Parameters.Add("CPF", OleDbType.VarChar, 11, "CPF");
            comInsertCliente.Parameters.Add("TELEFONE", OleDbType.VarChar, 11, "TELEFONE");
            comInsertCliente.Connection = new OleDbConnection(ConnStr);
            DACliente.InsertCommand = comInsertCliente;

        }
    }
}
