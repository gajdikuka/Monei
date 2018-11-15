using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.ViewModels
{
    class MainBalSavViewModel : INotifyPropertyChanged
    {
        private List<string> labelList;
        public List<string> LabelList
        {
            get { return labelList; }
            set { labelList = value; }
        }

        private string _username = Globals.LoggedInUser;
        private string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
