using monei_project.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle;

namespace monei_project.Models
{
    class DataBaseCommand
    {
        private DataBaseManager dataBaseManager = new DataBaseManager();
        public string getPassword(User user)
        {
            //return DataBaseManager.sendTextCommand("select password from monei_user where userid = " + user.UserId + ";").ToString();
            return null;
        }
        public void inserNewUser(User user)
        {
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandText = "Insert_User";

            
            oracleCommand.Parameters.Add("p_Username", OracleDbType.Varchar2).Value = user.Username;
            oracleCommand.Parameters.Add("p_Forename", OracleDbType.Varchar2).Value = user.Forename;
            oracleCommand.Parameters.Add("p_Lastname", OracleDbType.Varchar2).Value = user.LastName;
            oracleCommand.Parameters.Add("p_Password", OracleDbType.Byte).Value = user.Password;
            oracleCommand.Parameters.Add("p_SecurityQuestion", OracleDbType.Int16).Value = user.SecurityQuestion;
            oracleCommand.Parameters.Add("p_SecurityAnswer", OracleDbType.Varchar2).Value = user.AnswerToSecurityQuestion;

            dataBaseManager.sendStoredProcedureCall(oracleCommand);
        }
    }
}
