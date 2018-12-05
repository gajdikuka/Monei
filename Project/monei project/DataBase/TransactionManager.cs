using monei_project.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace monei_project.DataBase
{
    class TransactionManager : BaseDataBaseConnection
    {
        public void createNewTransaction(Transaction transaction)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = connection;
            if (transaction.UserNote != "")
            {
                oracleCommand.CommandText = "Insert_Transaction_With_Note";
                oracleCommand.Parameters.Add("p_TransactionName", OracleDbType.Varchar2).Value = transaction.TransactionName;
            }
            else
                oracleCommand.CommandText = "Insert_Transaction";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_AccountId", OracleDbType.Varchar2).Value = transaction.AccountId;
            oracleCommand.Parameters.Add("p_UserId", OracleDbType.Varchar2).Value = transaction.UserId;
            oracleCommand.Parameters.Add("p_Crediting", OracleDbType.Varchar2).Value = transaction.Crediting;
            oracleCommand.Parameters.Add("p_UserNote", OracleDbType.Varchar2).Value = transaction.UserNote;
            oracleCommand.ExecuteNonQuery();
            connection.Close();
        }
        public List<Account> getAccounts(User user)
        {
            OracleConnection connection = getConnection();
            List<Account> list = new List<Account>();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM monei_account WHERE userid = {user.Id}";
            command.Connection = connection;


            try
            {
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Account account = new Account();
                    account.AccountId = int.Parse(reader["accountid"].ToString());
                    account.AccountName = reader["accountname"].ToString();
                    account.OwnerId = int.Parse(reader["userid"].ToString());
                    account.Ammount = Convert.ToDouble(reader["amount"].ToString());
                    account.Currency = reader["currency"].ToString();
                    //account.Creatdate = reader["creatdate"].ToString();
                    list.Add(account);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                MessageBox.Show("Exception Source: " + ex.Source);
            }

            connection.Close();
            return list;
        }
    }
}
