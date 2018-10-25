using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Models
{
    class User
    {
        private int userId, securityquestion;
        private string userName, foreName, lastName, password, securityAnswer;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public int Securityquestion
        {
            get { return securityquestion; }
            set { securityquestion = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string ForeName
        {
            get { return foreName; }
            set { foreName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string SecurityAnswer
        {
            get { return securityAnswer; }
            set { securityAnswer = value; }
        }

        public User ( int userId, int securityquestion, string userName, string foreName, string lastName, string password, string securityAnswer)
        {
            this.userId = userId;
            this.securityquestion = securityquestion;
            this.userName = userName;
            this.foreName = foreName;
            this.lastName = lastName;
            this.password = password;
            this.securityAnswer = securityAnswer;
        }

    }
}
