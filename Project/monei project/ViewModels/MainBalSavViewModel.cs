using monei_project.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace monei_project.ViewModels
{
    class MainBalSavViewModel : ViewModelBase
    {
        private List<string> labelList;
        public List<string> LabelList
        {
            get { return labelList; }
            set { labelList = value; }
        }

        private string _username = Globals.LoggedInUser;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _backGroundColor;

        public string BackGroundColor
            {
                get { return _backGroundColor; }
                set { _backGroundColor = value; OnPropertyChanged("BackGroundColor"); }
            }


        ICommand _doBackGroundColor;

        public ICommand DoBackGroundColor
        {
            get
            {
                if (_doBackGroundColor == null)
                {
                    _doBackGroundColor = new RelayCommand(CanDoBackGroundColor, DoBackGroundColorExecute);
                }
                return _doBackGroundColor;
            }
        }

        private bool CanDoBackGroundColor(object obj)
        {
            return true;
        }

        private void DoBackGroundColorExecute(object obj)
        {
            BackGroundColor = "#000000";
        }

       
    }

}
