using System;
using System.ComponentModel;

namespace design_teszt.Models
{
    class User : INotifyPropertyChanged, IDataErrorInfo
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

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                string result = String.Empty;
                switch (propertyName)
                {
                    case "Username":
                        if (string.IsNullOrEmpty(Username))
                            result = "A felhasználónév megadása kötelező!"; break;
                    case "Forename":
                        if (string.IsNullOrEmpty(Forename))
                            result = "A keresztnév megadása kötelező!"; break;
                    case "LastName":
                        if (string.IsNullOrEmpty(LastName))
                            result = "A vezetéknév megadása kötelező!"; break;
                    case "Password":
                        if (string.IsNullOrEmpty(Password))
                            result = "A jelszó megadása kötelező!"; break;
                    case "SecurityQuestion":
                        if (string.IsNullOrEmpty(SecurityQuestion))
                            result = "A biztonsági kérdés megadása kötelező!"; break;
                    case "AnswerToSecurityQuestion":
                        if (string.IsNullOrEmpty(AnswerToSecurityQuestion))
                            result = "A biztonsági válasz megadása kötelező!"; break;
                }

                return result;
            }
        }

        public User()
        {

        }
            
        public User(string username, string forename, string lastName, string password, string securityQuestion, string answerToSecurityQuestion)
        {
            _username = username;
            _forename = forename;
            _lastName = lastName;
            _password = password;
            _securityQuestion = securityQuestion;
            _answerToSecurityQuestion = answerToSecurityQuestion;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
