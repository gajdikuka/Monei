using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Model
{
    class DataBaseConnection
    {
        protected DataBaseConnection() { }
        static private string connectionString
        {
            get { return "Data Source=donfamilia.tk;User Id=W1O67X; Password=killmepls"; }
        }
        static protected OracleConnection getConnection()
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
    }
}
