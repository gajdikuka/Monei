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
        public string getPassword(User user)
        {
            
            OracleConnection connection = getConnection();
            connection.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT password FROM user where userid = " + user.Password;
            command.Connection = connection;
            OracleDataReader reader = command.ExecuteReader();
            return reader.ToString();
        }

    }
}
