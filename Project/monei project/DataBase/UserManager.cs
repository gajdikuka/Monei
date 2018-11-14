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
    class UserManager : BaseDataBaseConnection
    {
        public void inserNewUser(User user)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = connection;
            oracleCommand.CommandText = "Insert_User";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = user.Username;
            oracleCommand.Parameters.Add("p_Forename", OracleDbType.Varchar2).Value = user.Forename;
            oracleCommand.Parameters.Add("p_Lastname", OracleDbType.Varchar2).Value = user.LastName;
            oracleCommand.Parameters.Add("p_Password", OracleDbType.Varchar2).Value = user.Password;
            oracleCommand.Parameters.Add("p_SecurityQuestion", OracleDbType.Int16).Value = user.SecurityQuestion;
            oracleCommand.Parameters.Add("p_SecurityAnswer", OracleDbType.Varchar2).Value = user.AnswerToSecurityQuestion;
            oracleCommand.ExecuteNonQuery();
            connection.Close();
        }

        public bool getUsername(string username)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand("Get_Username", connection);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_ReturningUsername", OracleDbType.Varchar2, 50, null, ParameterDirection.Output);
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = username;
            oracleCommand.BindByName = true;

            try
            {
                oracleCommand.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                MessageBox.Show("Exception Source: " + ex.Source);
            }
            
            string tmp = oracleCommand.Parameters["p_ReturningUsername"].Value.ToString();
            connection.Close();
            return tmp == username;
        }

        public string getPassword(string username)
        {
            OracleConnection connection = getConnection();
            OracleCommand oracleCommand = new OracleCommand("Get_Password", connection);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_Password", OracleDbType.Varchar2, 500, null, ParameterDirection.Output);
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = username;
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


            string tmp = oracleCommand.Parameters["p_Password"].Value.ToString();
            connection.Close();
            return tmp;
        }
    }
}
