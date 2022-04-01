using Aula3.Cadastro;
using Aula3.Processo;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aula3
{
    public partial class Form1 : Form
    {
        //String Conexão Oracle 
        string ConnSrt = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter  DAcadastrocliente;
        DataSet DScadastrocliente;
        OleDbCommand comInsertCliente;


        public Form1()
        {
            InitializeComponent();
            //Pega as informações da tabela Cliente e da um Fill (preenchimento)
            string sqlCliente = "select LOC_CLIENTE order by codigo";
            DAcadastrocliente = new OleDbDataAdapter(sqlCliente, ConnSrt);
            DScadastrocliente = new DataSet("LOC_CLIENTE");
            DAcadastrocliente.FillSchema(DScadastrocliente, SchemaType.Source);
            DAcadastrocliente.Fill(DScadastrocliente);


            //Insert 
            string sqlInsert = "insert into LOC_CLIENTE(nome,cpf,telefone) values(?,?,?,?)";
            comInsertCliente = new OleDbcommand(sqlInsert);
            comInsertCliente.Parameters.Add("nome", OleDbType.VarChar, 60, "nome");
            comInsertCliente.Parameters.Add("cpf", OleDbType.VarChar, 11, "cpf");
            comInsertCliente.Parameters.Add("telefone", OleDbType.VarChar, 11, "telefone");
            comInsertCliente.Connection = new OleDbConnection(ConnSrt);
            DAcadastrocliente.InsertCommand = comInsertCliente;

        }
        
        private void tsSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsCliente_Click(object sender, EventArgs e)
        {
            Cadastro.FormCliente frmCliente = new FormCliente();
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
