using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Aulla1
{
    public partial class Form_Aula1 : Form
    {
        //string conexão oracle
        string connStr = "Provider=msdaora; Data Source=LOCAL; USER id=local; Password=local;";

        public Form_Aula1()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbNome.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();        
        }
    }
}