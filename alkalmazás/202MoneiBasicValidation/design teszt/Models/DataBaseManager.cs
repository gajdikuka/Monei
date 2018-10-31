using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Models
{
    class DataBaseManager : DataBaseConnection
    {
        public OracleDataReader sendTextCommand(string command)
        {
            OracleConnection connection = getConnection();
            connection.Open();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = CommandType.Text;
            oracleCommand.CommandText = command;
            oracleCommand.Connection = connection;
            return oracleCommand.ExecuteReader();
        }

    }
}
