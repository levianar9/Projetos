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

            //Preenchimento da tabela 
            string sqlQ = "select * from CADASTRO_PESSOA";
            daPessoa = new OleDbDataAdapter(sqlQ, connStr);
            dsPessoa = new DataSet("CADASTRO_PESSOA");
            daPessoa.Fill(dsPessoa);

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
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DataRow reg = dsPessoa.Tables[0].NewRow();
            reg["CODIGO"] = tbCodigo.Text;
            reg["NOME"] = tbNome.Text;
            reg["EMAIL"] = tbEmail.Text;
            reg["TELEFONE"] = tbTelefone.Text;
            dsPessoa.Tables[0].Rows.Add(reg);
            daPessoa.Update(dsPessoa);

            MessageBox.Show("Usuário Cadastrado");
        }
    }
}
