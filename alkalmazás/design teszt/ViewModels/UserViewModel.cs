using design_teszt.Commands;
using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;

namespace design_teszt.ViewModels
{
    class UserViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        private string _username;
        [Required(ErrorMessage = "Felhasználónév kötelező.")]
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                ValidateProperty("Username", value);
            }
        }

        private string _forename;
        [Required(ErrorMessage = "Keresztnév kötelező.")]
        public string Forename
        {
            get { return _forename; }
            set
            {
                _forename = value;
                ValidateProperty("Forename", value);
            }
        }

        private string _lastName;
        [Required(ErrorMessage = "Vezetéknév kötelező.")]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                ValidateProperty("LastName", value);
            }
        }

        private string _password;
        [Required(ErrorMessage = "Jelszó kötelező.")]
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                ValidateProperty("Password", value);
            }
        }

        private string _securityQuestion;
        [Required(ErrorMessage = "Biztonságikérdés kötelező.")]
        public string SecurityQuestion
        {
            get { return _securityQuestion; }
            set
            {
                _securityQuestion = value;
                ValidateProperty("SecurityQuestion", value);
            }
        }

        private string _answerToSecurityQuestion;
        [Required(ErrorMessage = "Válasz a biztonságikérdésre kötelező.")]
        public string AnswerToSecurityQuestion
        {
            get { return _answerToSecurityQuestion; }
            set
            {
                _answerToSecurityQuestion = value;
                ValidateProperty("AnswerToSecurityQuestion", value);
            }
        }

        private ICommand _doRegistration;
        public ICommand DoRegistration
        {
            get
            {
                if (_doRegistration == null)
                {
                    _doRegistration = new RelayCommand(
                        p => true,
                        p => this.Registration());
                }
                return _doRegistration;
            }
        }

        public string Error
        {
            get;
        }

        bool _isValid = false;

        public bool IsValid
        {
            get { return _isValid; }
            set { _isValid = value; }
        }

        public void Registration()
        {
            Validate();
            /*var hasUser = HasUserName(User.Username);

            if (hasUser)
            {
                this.Message = "A felhasználónév már használatban van, kérem válaszon másikat!";
                this.MsgVisible = true;
            }
            else*/ if (IsValid)
            {
                //var user = new User()
                //{
                Username = this.Username;
                Forename = this.Forename;
                LastName = this.LastName;
                SecurityQuestion = this.SecurityQuestion;
                AnswerToSecurityQuestion = this.AnswerToSecurityQuestion;
                Password = Convert.ToString(this.getMd5Hash(this.Password));
                //};


                //db.User.Add(user);
                //db.SaveChanges();

                //this.Message = "A regisztráció sikeres!";
                //this.MsgVisible = true;
            }
        }

        byte[] getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            return data;
        }

        public bool HasUserName(string username)
        {
            //var hasuser = db.User.Any(u => u.UserName.ToLower() == username.ToLower());
            return true;
        }

        Dictionary<string, string> _errors = new Dictionary<string, string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private Dictionary<string, List<string>> _validationErrors = new Dictionary<string, List<string>>();

        public event EventHandler<DataErrorsChangedEventArgs>
           ErrorsChanged = delegate { };

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if(propertyName != null)
            {
                if (_validationErrors.ContainsKey(propertyName))
                    return _validationErrors[propertyName];
                else
                    return null;
            }
            else
            {
                return null;
            }
                
        }

        public bool HasErrors
        {
            get { return _validationErrors.Count > 0; }
        }

        private string ValidateProperty(string propertyName, object value)
        {
            string error = string.Empty;
            var results = new List<ValidationResult>();
            var result = Validator.TryValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = propertyName
            }, results);

            if (!result)
            {
                if (_validationErrors.ContainsKey(propertyName))
                    _validationErrors[propertyName].Clear();

                var messages = results.Select(r => r.ErrorMessage).ToList();
                _validationErrors.Add(propertyName, messages);

            }

            return error;
        }

        public void OnErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public void Validate()
        {
            var validationContext = new ValidationContext(this, null, null);
            var results = new List<ValidationResult>();
            var result = Validator.TryValidateObject(this, validationContext, results, true);

            //clear all previous errors
            var propNames = _validationErrors.Keys.ToList();
            _validationErrors.Clear();
            propNames.ForEach(pn => OnErrorsChanged(pn));

            if (!result)
            {
                var q = from r in results
                        from m in r.MemberNames
                        group r by m into g
                        select g;

                foreach (var prop in q)
                {
                    var messages = prop.Select(r => r.ErrorMessage).ToList();

                    if (_errors.ContainsKey(prop.Key))
                    {
                        _validationErrors.Remove(prop.Key);
                    }
                    _validationErrors.Add(prop.Key, messages);
                    OnErrorsChanged(prop.Key);
                }

                _isValid = false;
            }
            else
            {
                _isValid = true;
            }
        }

    }
}
