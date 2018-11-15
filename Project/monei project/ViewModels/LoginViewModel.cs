using monei_project.Commands;
using monei_project.Models;
using monei_project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace monei_project.ViewModels
{   
    class LoginViewModel : ViewModelBase
    {
        private static string _username;

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private static string _password;

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Ez a dologin kell?
        private ICommand _doLogin;
        public ICommand DoLogin
        {
            get
            {
                if (_doLogin == null)
                {
                    _doLogin = new RelayCommand(CanDoLogin, DoLoginExecute);
                }
                return _doLogin;
            }
        }

        private bool CanDoLogin(object arg)
        {
            return true; 
        }

        private void DoLoginExecute(object obj)
        {
            if (!GetHasValidationError())
            {
                Globals.LoggedInUser = "Username";
            }
        }

        private bool GetHasValidationError()
        {
            return LoginView.HasValidationError;
        }

        public static bool LoginChecking()
        {
            //if (getUsername(Username) && Password == getPassword(Username))
            if (Username == "asd" && Password == "asd")
                return true;
            else
                return false;
        }
    }
}
