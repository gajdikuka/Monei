using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class DataBaseManager : DataBaseConnection
    {
        public OracleDataReader sendTextCommand(string command)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = CommandType.Text;
            oracleCommand.CommandText = command;
            oracleCommand.Connection = connection;
            return oracleCommand.ExecuteReader();
        }

        public void sendStoredProcedureCall(OracleCommand oracleCommand)
        {
            oracleCommand.CommandType = CommandType.StoredProcedure;
            OracleConnection connection = getConnection();
            try
            {
                oracleCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }

            connection.Close(); 
        }
    }
}
