using monei_project.DataBase;
using monei_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Operations
{
    class UserHandler
    {
        public string userName{ get; set; }

        public UserHandler(string userName)
        {
            this.userName = userName;            
        }

        private void GetUser()
        {
            UserManager um = new UserManager(); 
        } 


    }
}
