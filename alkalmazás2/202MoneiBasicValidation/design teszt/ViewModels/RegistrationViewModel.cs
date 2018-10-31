using design_teszt.Commands;
using design_teszt.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace design_teszt.ViewModels
{
    class RegistrationViewModel : INotifyPropertyChanged
    {

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }//OnPropertyChanged(Username); }
        }

        private string _forename;

        public string Forename
        {
            get { return _forename; }
            set { _forename = value; }//OnPropertyChanged(Forename); }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }//OnPropertyChanged(LastName); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; } //OnPropertyChanged(Password); }
        }

        private string _securityQuestion;

        public string SecurityQuestion
        {
            get { return _securityQuestion; }
            set { _securityQuestion = value; }//OnPropertyChanged(SecurityQuestion); }
        }

        private string _answerToSecurityQuestion;

        public string AnswerToSecurityQuestion
        {
            get { return _answerToSecurityQuestion; }
            set { _answerToSecurityQuestion = value; }//OnPropertyChanged(AnswerToSecurityQuestion); }
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
            return true; //Meg lehet nyomni a gombot
        }

        private void SubmitExecute(object obj)
        {
            // Gombnyomásra ezt csinálja
            DataBaseCommand.insertNewUser(int userId, string username, string forename, string lastname, string password, int securityQuestion, string securityAnswer);
        }

    }
}
