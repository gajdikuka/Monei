using monei_project.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.DataBase
{
    class AccountManager : BaseDataBaseConnection
    {
        public void inserNewAccount(Account account)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = connection;
            oracleCommand.CommandText = "Insert_User";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_AccountName", OracleDbType.Varchar2).Value = account.AccountName;
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = account.Username;
            oracleCommand.Parameters.Add("p_Ammount", OracleDbType.Varchar2).Value = account.Ammount;
            oracleCommand.Parameters.Add("p_Currency", OracleDbType.Varchar2).Value = account.Currency;
            oracleCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
