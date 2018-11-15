using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.ViewModels
{
    class MainFelsoViewModel : INotifyPropertyChanged
    {
        private string _balance;

        public string Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetBalance()
        {
            Balance = "érték";
        }
    }
}
