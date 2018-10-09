using design_teszt.Commands;
using design_teszt.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace design_teszt.ViewModels
{
    class UserViewModel : INotifyPropertyChanged
    {

        private User _user = new User();

        public User User
        {
            get { return _user; }
            set { _user = value; NotifyPropertyChanged("User"); }
        }

        private ObservableCollection<User> _users = new ObservableCollection<User>();
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value; NotifyPropertyChanged("Users"); }
        }

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _SubmitCommand;                
            }
        }

        private bool CanSubmitExecute(object arg)
        {
            /*if (string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Forename) || string.IsNullOrEmpty(User.LastName) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.SecurityQuestion) || string.IsNullOrEmpty(User.AnswerToSecurityQuestion))
            {
                return false;
            }
            else
            {*/
                return true;
            //} 
        }

        private void SubmitExecute(object obj)
        {
            Users.Add(User);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
