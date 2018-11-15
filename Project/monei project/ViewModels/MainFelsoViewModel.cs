using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.ViewModels
{
    class MainFelsoViewModel : ViewModelBase
    {

        private string _balance;
        public string Balance
        {
            get { return _balance; }
            set { SetAndRaisePropertyChanged(ref _balance, "1111$"); }
        }

        public void SetBalance()
        {
            Balance = "érték";
        }
    }
}
