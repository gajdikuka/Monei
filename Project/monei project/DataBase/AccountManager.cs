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
        public List<string> getAccount(string username)
        {
            List<string> list = new List<string>();
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand("Get_Amount", connection);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_AccountName", OracleDbType.Varchar2, 500, null, ParameterDirection.ReturnValue);
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = username;
            oracleCommand.BindByName = true;
            try
            {
                OracleDataReader reader = oracleCommand.ExecuteReader();
                while (reader.Read())
                    list.Add(reader["p_AccountName"].ToString());
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
            }
            connection.Close();
            return list;
        }
        public string getAmount(string accountName)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand("Get_Amount", connection);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_Ammount", OracleDbType.Varchar2, 500, null, ParameterDirection.ReturnValue);
            oracleCommand.Parameters.Add("p_AccountName", OracleDbType.Varchar2).Value = accountName;
            oracleCommand.BindByName = true;
            try
            {
                oracleCommand.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
            }

            string tmp = oracleCommand.Parameters["p_Ammount"].Value.ToString();
            connection.Close();
            return tmp;
        }
        public string getCurrency(string accountName)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand("Get_Amount", connection);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_AccountName", OracleDbType.Varchar2, 500, null, ParameterDirection.ReturnValue);
            oracleCommand.Parameters.Add("p_AccountName", OracleDbType.Varchar2).Value = accountName;
            oracleCommand.BindByName = true;
            try
            {
                oracleCommand.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
            }

            string tmp = oracleCommand.Parameters["p_Currency"].Value.ToString();
            connection.Close();
            return tmp;
        }
    }
}