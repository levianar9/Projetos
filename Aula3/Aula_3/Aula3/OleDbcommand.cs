using System;
using System.Data.OleDb;

namespace Aula3
{
    internal class OleDbcommand
    {
        private string sqlInsert;

        public OleDbcommand(string sqlInsert)
        {
            this.sqlInsert = sqlInsert;
        }

        public object Parameters { get; internal set; }
        public OleDbConnection Connection { get; internal set; }

        public static implicit operator OleDbCommand(OleDbcommand v)
        {
            throw new NotImplementedException();
        }
    }
}