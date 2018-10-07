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
using design_teszt.Views;

namespace design_teszt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginView loginview = new LoginView();
        public RegistrationView registrationview = new RegistrationView();
        public UserControl1 asd1 = new UserControl1();

        public MainWindow()
        {
            InitializeComponent();
            maingrid.Children.Add(loginview);
            LoginView.Bejelentkezes += new EventHandler(LoginView_Bejelentkezes);
            LoginView.Regisztracio += new EventHandler(LoginView_Regisztracio);
            RegistrationView.Regisztracio += new EventHandler(RegistrationView_Regisztracio);
            RegistrationView.Vissza += new EventHandler(RegistrationView_Vissza);
        }   

        void LoginView_Bejelentkezes(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(asd1);
        }

        void LoginView_Regisztracio(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(registrationview);
        }

        void RegistrationView_Regisztracio(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(loginview);
        }

        void RegistrationView_Vissza(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(loginview);
        }

    }
}
