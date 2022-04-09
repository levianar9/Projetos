using System;
using System.Data;
using System.Data.OleDb;

namespace Aula_3.Cadastro
{
    internal class OledDataAdapter
    {
        private string sqlPessoa;
        private string ConnStr;

        public OleDbCommand InsertCommand { get; internal set; }

        public OledDataAdapter(string sqlPessoa, string connStr)
        {
            this.sqlPessoa = sqlPessoa;
            this.ConnStr = connStr;
        }

        internal void FillSchema(DataSet DSCliente, SchemaType source)
        {
            throw new NotImplementedException();
        }

        internal void Fill(DataSet DSCliente)
        {
            throw new NotImplementedException();
        }

        internal void Update(DataSet DSCliente)
        {
            throw new NotImplementedException();
        }

        public static implicit operator OledDataAdapter(OleDbDataAdapter v)
        {
            throw new NotImplementedException();
        }
    }
}