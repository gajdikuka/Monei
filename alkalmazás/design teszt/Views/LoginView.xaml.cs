﻿using System;
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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public static event EventHandler Bejelentkezes;
        public static event EventHandler Regisztracio;


        public void login(object sender, RoutedEventArgs e)
        {
            if (Bejelentkezes != null)
            {
                Bejelentkezes(this, e);
            }
        }

        private void register(object sender, RoutedEventArgs e)
        {
            if (Regisztracio != null)
            {
                Regisztracio(this, e);
            }
        }
    }
}
