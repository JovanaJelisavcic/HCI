﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HCI_2._3bv
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public int id { get; set; }

        public Window3()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ponisti_etiketu(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void sacuvaj_etiketu(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sačuvan tag");
            this.Close();
        }
    }
}
