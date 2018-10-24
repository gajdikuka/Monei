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

        public int UserId { get; set; }
        public int Securityquestion { get; set; }
        public string UserName { get; set; }
        public string ForeName { get; set; }
        public string LastName { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string SecurityAnswer { get; set; }

    }
}
