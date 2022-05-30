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
using System.Windows.Shapes;

namespace City_Planner
{
    /// <summary>
    /// Interaction logic for Segitseg.xaml
    /// </summary>
    public partial class Segitseg : Window
    {
        public Segitseg()
        {
            InitializeComponent();
        }

        private void bezar_Click(object sender, RoutedEventArgs e)
        {
                foablak.Close();
        }
    }
}
