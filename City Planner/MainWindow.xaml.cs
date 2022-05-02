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

namespace City_Planner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Jatek subWindow = new Jatek();
            subWindow.Show();
            foablak.Close();
        }

        private void eredmeny_Click(object sender, RoutedEventArgs e)
        {
            Eredmenyek subWindow = new Eredmenyek();
            subWindow.Show();
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            foablak.Close();
        }
    }
}
