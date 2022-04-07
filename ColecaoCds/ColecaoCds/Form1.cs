using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace ColecaoCds
{
    public partial class Form1 : Form
    {
        //Conexão Banco Oracle 
        string ConnStr = "Provider=msdaora; Data Source = LOCAL; User id=local; Password=local;";
        OleDbDataAdapter daCd;
        DataSet dsCd;
        OleDbCommand comInsert;
        public Form1()
        {
            InitializeComponent();
            //Precher dados na tabela e dar um Fill (preenchimento)
            string sqlQ = "select * from CDs";
            daCd = new OleDbDataAdapter(sqlQ,ConnStr);
            dsCd = new DataSet("CDs");
            daCd.Fill(dsCd);

            //Insert
            string sqlInsert = "insert into Cds (id, album, artista, ano) values (?,?,?,?)";
            comInsert = new OleDbCommand(sqlInsert);
            comInsert.Parameters.Add("ID", OleDbType.Numeric, 4, "ID");
            comInsert.Parameters.Add("ALBUM", OleDbType.VarChar, 25, "ALBUM");
            comInsert.Parameters.Add("ARTISTA", OleDbType.VarChar, 25, "ARTISTA");
            comInsert.Parameters.Add("ANO", OleDbType.Numeric, 4, "ANO");
            comInsert.Connection = new OleDbConnection(ConnStr);
            daCd.InsertCommand = comInsert;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DataRow reg = dsCd.Tables[0].NewRow();

            reg["ID"] = tbId.Text;
            reg["ALBUM"] = tbAlbum.Text;
            reg["ARTISTA"] = tbArtista.Text;
            reg["ANO"] = tbAno.Text;

            dsCd.Tables[0].Rows.Add(reg);
            daCd.Update(dsCd);

            MessageBox.Show("Cd Cadastrado");
        }
    }
}
