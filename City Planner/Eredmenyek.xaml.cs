﻿using System;
using System.IO;
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
using System.Windows.Shapes;

namespace City_Planner
{
    /// <summary>
    /// Interaction logic for Eredmenyek.xaml
    /// </summary>
    public partial class Eredmenyek : Window
    {
        string vasut = "";
        public Eredmenyek()
        {
            InitializeComponent();
        }

        private void eredmenyablak_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("vasut.txt"))
            {
                nice.Content = "nicerrr";
            }
        }
    }
}
