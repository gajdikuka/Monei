using monei_project.Commands;
using monei_project.Models;
using monei_project.Views;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace monei_project.ViewModels
{   
    class RegistrationViewModel : INotifyPropertyChanged
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _forename;

        public string Forename
        {
            get { return _forename; }
            set { _forename = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
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

        private string _securityQuestion;

        public string SecurityQuestion
        {
            get { return _securityQuestion; }
            set { _securityQuestion = value; }
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

        private ICommand _doRegistration;
        public ICommand DoRegistration
        {
            get
            {
                if (_doRegistration == null)
                {
                    _doRegistration = new RelayCommand(CanSubmitExecute, SubmitExecute);
                }
                return _doRegistration;                
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
                var user = new User()
                {
                    Username = this.Username,
                    Forename = this.Forename,
                    LastName = this.LastName,
                    Password = this.getHashSha256(this.Password),
                    SecurityQuestion = this.SecurityQuestion,
                    AnswerToSecurityQuestion = this.AnswerToSecurityQuestion,
                };

                DataBaseCommand dataBaseCommand = new DataBaseCommand();
                dataBaseCommand.inserNewUser(user);
            }
        }

        private bool GetHasValidationError()
        {
            return RegistrationView.HasValidationError;
        }

        public string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

    }
}
