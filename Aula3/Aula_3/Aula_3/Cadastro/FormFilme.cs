using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Aula_3.Cadastro
{
    public partial class FormFilme : Form
    {

        // String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DAFilme;
        DataSet DSFilme;
        OleDbCommand comInsertFilme, comSelectGeral;

        private void btIncluir_Click(object sender, EventArgs e)
        {
            // Busca SEQFILME
            string sqlSequenceCliente = "SELECT S_LOC_FILME.NEXTVAL FROM DUAL";
            comSelectGeral = new OleDbCommand(sqlSequenceCliente);
            comSelectGeral.Connection = new OleDbConnection(ConnStr);
            comSelectGeral.Connection.Open();
            int SeqFilme = int.Parse(comSelectGeral.ExecuteScalar().ToString());

            //Select que puxa o cod de cargo do determinado Processo Seletivo.
            string sqlSeqGenero = "SELECT SEQGENERO FROM LOC_GENERO WHERE GENERO = '" + cbGenero.Text + "'";
            comSelectGeral = new OleDbCommand(sqlSeqGenero);
            comSelectGeral.Connection = new OleDbConnection(ConnStr);
            comSelectGeral.Connection.Open();
            int SeqGenero = int.Parse(comSelectGeral.ExecuteScalar().ToString());

            try
            {
                DataRow linha = DSFilme.Tables[0].NewRow();
                linha["SEQFILME"] = SeqFilme;
                linha["FILME"] = tbFilme.Text;
                linha["SEQGENERO"] = SeqGenero;

                DSFilme.Tables[0].Rows.Add(linha);
                DAFilme.Update(DSFilme);

                MessageBox.Show("Filme cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tbFilme.Clear();
        }

        public FormFilme()
        {
            InitializeComponent();
            string sqlPessoa = "SELECT * FROM LOC_FILME";
            DAFilme = new OleDbDataAdapter(sqlPessoa, ConnStr);
            DSFilme = new DataSet("LOC_FILME");
            DAFilme.FillSchema(DSFilme, SchemaType.Source);
            DAFilme.Fill(DSFilme);

            // Insert Filme
            string sqlInsert = "INSERT INTO LOC_FILME(SEQFILME,FILME,SEQGENERO) values(?,?,?)";
            comInsertFilme = new OleDbCommand(sqlInsert);
            comInsertFilme.Parameters.Add("SEQFILME", OleDbType.Numeric, 9, "SEQFILME");
            comInsertFilme.Parameters.Add("FILME", OleDbType.VarChar, 60, "FILME");
            comInsertFilme.Parameters.Add("SEQGENERO", OleDbType.Numeric, 9, "SEQGENERO");
            comInsertFilme.Connection = new OleDbConnection(ConnStr);
            DAFilme.InsertCommand = comInsertFilme;

            // ComboBox
            string sqlcnpj = "select GENERO FROM LOC_GENERO";
            OleDbDataAdapter daTeste = new OleDbDataAdapter(sqlcnpj, ConnStr);
            DataTable dtResultado = new DataTable();
            daTeste.Fill(dtResultado);
            cbGenero.DataSource = dtResultado;
            cbGenero.DisplayMember = "GENERO";
        }
    }
}
