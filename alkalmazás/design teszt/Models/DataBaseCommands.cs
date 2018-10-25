using design_teszt.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Models
{
    class DataBaseCommands
    {
        public string getPassword(User user)
        {
            return DataBaseManager.sendTextCommand("select password from monei_user where userid = " + user.UserId + ";").ToString();
        }
        public void inserNewUser(User user)
        {
            DataBaseManager.sendTextCommand("insert into monei_user (userid, username, forename, lastname, password, securityquestion, securityanswer) values (" + user.UserId + ", " + user.UserName + ", " + user.ForeName + ", " + user.LastName + ", " + user.Password + ", " + user.Securityquestion + ", " + user.SecurityAnswer + ");");
        }
    }
}
