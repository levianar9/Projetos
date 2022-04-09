using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Aula_3.Cadastro;
using Aula_3.Consulta;

namespace Aula_3.Consulta
{
    public partial class FormConsultaCliente : Form
    {
        // String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DACliente;
        DataSet DSCliente;
        FormCliente FrmCliente;
        private FormCliente frmCliente;

        public FormConsultaCliente(Cadastro.FormCliente formCliente)
        {
            InitializeComponent();

            FrmCliente = frmCliente;
            FrmCliente = new FormCliente();

            string sqlPessoa = "SELECT * FROM LOC_CLIENTE";
            DACliente = new OleDbDataAdapter(sqlPessoa, ConnStr);
            DSCliente = new DataSet("LOC_CLIENTE");
            DACliente.FillSchema(DSCliente, SchemaType.Source);
            DACliente.Fill(DSCliente);

            dgConsultaCliente.DataSource = DSCliente.Tables[0];
            dgConsultaCliente.Columns["seqcliente"].HeaderText = "Código";
            dgConsultaCliente.Columns["nome"].HeaderText = "Nome";
            dgConsultaCliente.Columns["cpf"].HeaderText = "CPF";
            dgConsultaCliente.Columns["telefone"].HeaderText = "Telefone";
        }
    }
}
