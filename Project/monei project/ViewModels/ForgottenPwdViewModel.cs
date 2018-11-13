using monei_project.Commands;
using monei_project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace monei_project.ViewModels
{
    class ForgottenPwdViewModel : INotifyPropertyChanged
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

        private string _passwordConformation;
        public string PasswordConformation
        {
            get { return _passwordConformation; }
            set { _passwordConformation = value; }
        }

        private string _answerToSecurityQuestion;

        public string AnswerToSecurityQuestion
        {
            get { return _answerToSecurityQuestion; }
            set { _answerToSecurityQuestion = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private ICommand _doPasswordChange;
        public ICommand DoPasswordChange
        {
            get
            {
                if (_doPasswordChange == null)
                {
                    _doPasswordChange = new RelayCommand(CanSubmitExecute, SubmitExecute);
                }
                return _doPasswordChange;
            }
        }

        private bool CanSubmitExecute(object arg)
        {
            return true; 
        }

        private void SubmitExecute(object obj)
        {
            if(!GetHasValidationError())
            {
                //Ide jöhet, ami gombnyomásra történik
            }
        }

        private bool GetHasValidationError()
        {
            return ForgottenPwdView3.HasValidationError;
        }
    }
}

