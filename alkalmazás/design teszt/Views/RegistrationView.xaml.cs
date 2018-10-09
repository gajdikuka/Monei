using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace design_teszt.Views
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        public static event EventHandler Regisztracio;
        public static event EventHandler Vissza;

        private void register(object sender, RoutedEventArgs e)
        {


            if (Regisztracio != null)
            {
                Regisztracio(this, e);
            }
        }

        private void back(object sender, RoutedEventArgs e)
        {
            if (Vissza != null)
            {
                Vissza(this, e);
            }
        }
    }
}
