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
using monei_project.Views;

namespace monei_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginView loginview = new LoginView();
        public RegistrationView registrationview = new RegistrationView();
        public RegistrationView2 registrationview2 = new RegistrationView2();
        public fokepernyo fokepernyo = new fokepernyo();
        public Elfelejtett1View elfelejtett1 = new Elfelejtett1View();
        public Elfelejtett2View elfelejtett2 = new Elfelejtett2View();
        public Elfelejtett3View elfelejtett3 = new Elfelejtett3View();
        public Elfelejtett4View elfelejtett4 = new Elfelejtett4View();

        public MainWindow()
        {
            InitializeComponent();
            maingrid.Children.Add(loginview);

            LoginView.Bejelentkezes += new EventHandler(LoginView_Bejelentkezes);
            LoginView.Regisztracio += new EventHandler(LoginView_Regisztracio);
            LoginView.Elfelejtett += new EventHandler(LoginView_Elfelejtett);

            RegistrationView.Regisztracio += new EventHandler(RegistrationView_Regisztracio);
            RegistrationView.Vissza += new EventHandler(Vissza);

            RegistrationView2.Vissza += new EventHandler(Vissza);

            Elfelejtett1View.Vissza += new EventHandler(Vissza);
            Elfelejtett1View.Biztonsagi += new EventHandler(Elfelejtett1View_Biztonsagi);

            Elfelejtett2View.Kuldes += new EventHandler(Elfelejtett2View_Kuldes);
            Elfelejtett2View.Vissza += new EventHandler(Vissza);

            Elfelejtett3View.Beallitas += new EventHandler(Elfelejtett3View_Beallitas);
            Elfelejtett3View.Vissza += new EventHandler(Vissza);

            Elfelejtett4View.Vissza += new EventHandler(Vissza);
        }   

        void LoginView_Bejelentkezes(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(fokepernyo);
        }

        void LoginView_Regisztracio(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(registrationview);
        }

        void LoginView_Elfelejtett(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett1);
        }

        void RegistrationView_Regisztracio(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(registrationview2);
        }

        void Vissza(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(loginview);
        }

        void Elfelejtett1View_Biztonsagi(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett2);
        }

        void Elfelejtett2View_Kuldes(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett3);
        }

        void Elfelejtett3View_Beallitas(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett4);
        }


}
}
