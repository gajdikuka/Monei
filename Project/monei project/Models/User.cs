﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class User
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

        private int _securityQuestion;

        public int SecurityQuestion
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

        public User()
        {

        }
        public User(string username, string forename, string lastName, string password, int securityQuestion, string answerToSecurityQuestion)
        {
            this.Username = username;
            this.Forename = forename;
            this.LastName = lastName;
            this.Password = password;
            this.SecurityQuestion = securityQuestion;
            this.AnswerToSecurityQuestion = answerToSecurityQuestion;
        }
    }
}
