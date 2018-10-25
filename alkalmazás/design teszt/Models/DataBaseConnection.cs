using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace design_teszt.Models
{
    class DataBaseConnection
    {
        protected DataBaseConnection() { }
        private string connectionString
        {
            get { return "Data Source=donfamilia.tk;User Id=W1O67X; Password=killmepls"; }
        }
        protected OracleConnection getConnection()
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
    }
}
