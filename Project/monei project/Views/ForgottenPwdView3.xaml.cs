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

namespace monei_project.Views
{
    /// <summary>
    /// Interaction logic for Elfelejtett3View.xaml
    /// </summary>
    public partial class Elfelejtett3View : UserControl
    {
        public Elfelejtett3View()
        {
            InitializeComponent();
        }

        public static event EventHandler Beallitas;
        public static event EventHandler Vissza;

        private void back(object sender, RoutedEventArgs e)
        {
            if (Vissza != null)
            {
                Vissza(this, e);
            }
        }

        private void beallitas(object sender, RoutedEventArgs e)
        {
            if (Beallitas != null)
            {
                Beallitas(this, e);
            }
        }
    }
}
