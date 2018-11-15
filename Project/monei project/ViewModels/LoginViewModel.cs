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
    class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

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

    }
}
