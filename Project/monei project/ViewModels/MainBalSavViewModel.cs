using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string Username
        {
            get { return _username; }
            set { _username = value; }
        }

    }

}
