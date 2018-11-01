using monei_project.Commands;
using monei_project.Models;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
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
            return true; //Meg lehet-e nyomni a gombot
        }

        private void SubmitExecute(object obj)
        {
            var user = new User()
            {
                Username = this.Username,
                Forename = this.Forename,
                LastName = this.LastName,
                Password = this.getMd5Hash(this.Password),
                SecurityQuestion = this.SecurityQuestion,
                AnswerToSecurityQuestion = this.AnswerToSecurityQuestion,
            };

            //DataBaseCommand.insertNewUser(int userId, string username, string forename, string lastname, string password, int securityQuestion, string securityAnswer);
        }

        byte[] getMd5Hash(string input)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            return data;
        }

    }
}
