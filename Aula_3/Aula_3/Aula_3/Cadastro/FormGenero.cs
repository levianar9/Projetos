using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Aula_3.Cadastro
{
    public partial class FormGenero : Form
    {
        // String Conexão Oracle
        string ConnStr = "Provider=msdaora; Data Source=LOCAL; User Id=local; Password=local;";
        OleDbDataAdapter DAGenero;
        DataSet DSGenero;
        OleDbCommand comInsertGenero, comSelectGeral;

        public FormGenero()
        {
            InitializeComponent();

            string sqlPessoa = "SELECT * FROM LOC_GENERO";
            DAGenero = new OleDbDataAdapter(sqlPessoa, ConnStr);
            DSGenero = new DataSet("LOC_GENERO");
            DAGenero.FillSchema(DSGenero, SchemaType.Source);
            DAGenero.Fill(DSGenero);

            // Insert Genero
            string sqlInsert = "INSERT INTO LOC_GENERO(SEQGENERO,GENERO) values(?,?)";
            comInsertGenero = new OleDbCommand(sqlInsert);
            comInsertGenero.Parameters.Add("SEQGENERO", OleDbType.Numeric, 9, "SEQGENERO");
            comInsertGenero.Parameters.Add("GENERO", OleDbType.VarChar, 60, "GENERO");
            comInsertGenero.Connection = new OleDbConnection(ConnStr);
            DAGenero.InsertCommand = comInsertGenero;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            // Busca SEQGENERO
            string sqlSequenceCliente = "SELECT S_LOC_GENERO.NEXTVAL FROM DUAL";
            comSelectGeral = new OleDbCommand(sqlSequenceCliente);
            comSelectGeral.Connection = new OleDbConnection(ConnStr);
            comSelectGeral.Connection.Open();
            int SeqGenero = int.Parse(comSelectGeral.ExecuteScalar().ToString());

            try
            {
                DataRow linha = DSGenero.Tables[0].NewRow();
                linha["SEQGENERO"] = SeqGenero;
                linha["GENERO"] = tbGenero.Text;

                DSGenero.Tables[0].Rows.Add(linha);
                DAGenero.Update(DSGenero);

                MessageBox.Show("Gênero cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch
            {
                MessageBox.Show("Necessário preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            tbGenero.Clear();
        }



    }
}
