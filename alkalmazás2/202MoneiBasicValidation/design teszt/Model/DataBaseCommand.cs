using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Model
{
    class DataBaseCommand
    {
        static public void insertNewUser(int userId, string username, string forename, string lastname, string password, int securityQuestion, string securityAnswer)
        {
            DataBaseManager.sendTextCommand("insert into monei_user (userid, username, forename, lastname, password, securityquestion, securityanswer) values (" + userId + ", " + username + ", " + forename + ", " + lastname + ", " + password + ", " + securityQuestion + ", " + securityAnswer + ");");
        }
    }
}
