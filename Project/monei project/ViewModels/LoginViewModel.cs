using monei_project.Commands;
using monei_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    _doLogin = new RelayCommand(CanSubmitExecute, SubmitExecute);
                }
                return _doLogin;
            }
        }

        private bool CanSubmitExecute(object arg)
        {
            return true; //Meg lehet-e nyomni a gombot
        }

        private void SubmitExecute(object obj)
        {
    
        }
    }
}
