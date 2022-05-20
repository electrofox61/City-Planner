using System;
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
    /// Interaction logic for Jatek.xaml
    /// </summary>
    public partial class Jatek : Window
    {
        public Jatek()
        {
            InitializeComponent();
        }
        int[,] C1 = new int[9, 9];
        int[,] C2 = new int[9, 9];
        int[,] C3 = new int[9, 9];
        int[,] C4 = new int[9, 9];
        int[,] U1 = new int[9, 9];
        int[,] U2 = new int[9, 9];
        int[,] U3 = new int[9, 9];
        int[,] U4 = new int[9, 9];
        int kivalasztott = 0;
        int lako = 0;
        double penz = 0;
        int kor = 0;
        int gyar = 0;
        double jovedelem = 0;
        double boldogsag = 1;
        int korhaz = 0;
        int vasut = 0;
        public void achcheck() //nincs még meghívva
        {
            if (vasut > 200)
            {
                File.WriteAllText("vasut.txt", "true");
            }
        }
        public void lakoszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (C1[i, j] == 0)
                    {
                        lako++;
                    }
                    if (C2[i, j] == 0)
                    {
                        lako++;
                    }
                    if (C3[i, j] == 0)
                    {
                        lako++;
                    }
                    if (C4[i, j] == 0)
                    {
                        lako++;
                    }
                }
            }
        }
        public void gyarszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (C1[i, j] == 1)
                    {
                        gyar++;
                        boldogsag -= 0.25;
                    }
                    if (C2[i, j] == 1)
                    {
                        gyar++;
                        boldogsag -= 0.25;
                    }
                    if (C3[i, j] == 1)
                    {
                        gyar++;
                        boldogsag -= 0.25;
                    }
                    if (C4[i, j] == 1)
                    {
                        gyar++;
                        boldogsag -= 0.25;
                    }
                }
            }
        }
        public void boltszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (C1[i, j] == 2)
                    {
                        jovedelem++;
                    }
                    if (C2[i, j] == 2)
                    {
                        jovedelem++;
                    }
                    if (C3[i, j] == 2)
                    {
                        jovedelem++;
                    }
                    if (C4[i, j] == 2)
                    {
                        jovedelem++;
                    }
                }
            }
        }
        public void mulatszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (C1[i, j] == 3)
                    {
                        boldogsag++;
                    }
                    if (C2[i, j] == 3)
                    {
                        boldogsag++;
                    }
                    if (C3[i, j] == 3)
                    {
                        boldogsag++;
                    }
                    if (C4[i, j] == 3)
                    {
                        boldogsag++;
                    }
                }
            }
        }
        public void korhazszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (C1[i, j] == 4)
                    {
                        korhaz++;
                    }
                    if (C2[i, j] == 4)
                    {
                        korhaz++;
                    }
                    if (C3[i, j] == 4)
                    {
                        korhaz++;
                    }
                    if (C4[i, j] == 4)
                    {
                        korhaz++;
                    }
                }
            }
        }
        public void adatszam()
        {
            if (korhaz == 0)
                boldogsag -= 1;
            else if (korhaz == 1)
                boldogsag += 1;
            else if (korhaz == 2)
                boldogsag += 3;
            else if (korhaz == 3)
                boldogsag += 7;
            else if (korhaz > 3)
                boldogsag += 7 + korhaz * 0.1;
            boldogsagL.Content = Math.Round(boldogsag, 2);
            if (boldogsag == 0)
                boldogsag = 0.1;
            if (jovedelem >= gyar)
            {
                jovedelem = gyar;
            }
            jovedelem = Math.Round(jovedelem * boldogsag * lako * 0.5, 2);
            jovedelemL.Content = jovedelem;
            penz += jovedelem;
            penzL.Content = Math.Round(penz, 2);
            lakoL.Content = lako;
        }
        public void utszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (U1[i, j] == 0)
                    {
                    }
                    if (U2[i, j] == 0)
                    {
                    }
                    if (U3[i, j] == 0)
                    {
                    }
                    if (U4[i, j] == 0)
                    {
                    }
                }
            }
        }
        public void betonszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (U1[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.3;
                    }
                    if (U2[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.3;
                    }
                    if (U3[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.3;
                    }
                    if (U4[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.3;
                    }
                }
            }
        }
        public void vasutszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (U1[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.8;
                    }
                    if (U2[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.8;
                    }
                    if (U3[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.8;
                    }
                    if (U4[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.8;
                    }
                }
            }
        }
        public void Megjelenit()
        {
            jovedelem = 0;
            korhaz = 0;
            lako = 0;
            boldogsag = 1;
            lakoszam();
            gyarszam();
            boltszam();
            mulatszam();
            korhazszam();
            utszam();
            betonszam();
            vasutszam();

            adatszam();
            CityG1.Children.Clear();
            CityG2.Children.Clear();
            CityG3.Children.Clear();
            CityG4.Children.Clear();
            nulla.Fill = new ImageBrush(new BitmapImage(new Uri("living.png", UriKind.Relative)));
            nullaL.Content = "'0' gomb - Living";
            egy.Fill = new ImageBrush(new BitmapImage(new Uri("industrial.png", UriKind.Relative)));
            egyL.Content = "'1' gomb - Industrial";
            ket.Fill = new ImageBrush(new BitmapImage(new Uri("commercial.png", UriKind.Relative)));
            ketL.Content = "'2' gomb - Commercial";
            harom.Fill = new ImageBrush(new BitmapImage(new Uri("entertainment.png", UriKind.Relative)));
            haromL.Content = "'3' gomb - Entertainment";
            negy.Fill = new ImageBrush(new BitmapImage(new Uri("hospital.png", UriKind.Relative)));
            negyL.Content = "'4' gomb - Medical";
            harom.Visibility = Visibility.Visible;
            haromL.Visibility = Visibility.Visible;
            negy.Visibility = Visibility.Visible;
            negyL.Visibility = Visibility.Visible;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button b = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    b.Width = 150;
                    b.Height = 150;
                    b.Name = "x" + i + j;
                    b.Margin = margo;
                    switch (C1[i,j])
                    {
                        case 0:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("living.png", UriKind.Relative)));
                            break;
                        case 1:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("industrial.png", UriKind.Relative)));
                            break;
                        case 2:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("commercial.png", UriKind.Relative)));
                            break;
                        case 3:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("entertainment.png", UriKind.Relative)));
                            break;
                        case 4:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("hospital.png", UriKind.Relative)));
                            break;
                    }
                    b.Click += new RoutedEventHandler(varos1_Click);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    b.VerticalAlignment = VerticalAlignment.Center;
                    CityG1.Children.Add(b);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button b = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    b.Width = 150;
                    b.Height = 150;
                    b.Name = "x" + i + j;
                    b.Margin = margo;
                    switch (C2[i, j])
                    {
                        case 0:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("living.png", UriKind.Relative)));
                            break;
                        case 1:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("industrial.png", UriKind.Relative)));
                            break;
                        case 2:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("commercial.png", UriKind.Relative)));
                            break;
                        case 3:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("entertainment.png", UriKind.Relative)));
                            break;
                        case 4:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("hospital.png", UriKind.Relative)));
                            break;
                    }
                    b.Click += new RoutedEventHandler(varos2_Click);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    b.VerticalAlignment = VerticalAlignment.Center;
                    CityG2.Children.Add(b);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button b = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    b.Width = 150;
                    b.Height = 150;
                    b.Name = "x" + i + j;
                    b.Margin = margo;
                    switch (C3[i, j])
                    {
                        case 0:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("living.png", UriKind.Relative)));
                            break;
                        case 1:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("industrial.png", UriKind.Relative)));
                            break;
                        case 2:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("commercial.png", UriKind.Relative)));
                            break;
                        case 3:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("entertainment.png", UriKind.Relative)));
                            break;
                        case 4:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("hospital.png", UriKind.Relative)));
                            break;
                    }
                    b.Click += new RoutedEventHandler(varos3_Click);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    b.VerticalAlignment = VerticalAlignment.Center;
                    CityG3.Children.Add(b);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button b = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    b.Width = 150;
                    b.Height = 150;
                    b.Name = "x" + i + j;
                    b.Margin = margo;
                    switch (C4[i, j])
                    {
                        case 0:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("living.png", UriKind.Relative)));
                            break;
                        case 1:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("industrial.png", UriKind.Relative)));
                            break;
                        case 2:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("commercial.png", UriKind.Relative)));
                            break;
                        case 3:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("entertainment.png", UriKind.Relative)));
                            break;
                        case 4:
                            b.Background = new ImageBrush(new BitmapImage(new Uri("hospital.png", UriKind.Relative)));
                            break;
                    }
                    b.Click += new RoutedEventHandler(varos4_Click);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    b.VerticalAlignment = VerticalAlignment.Center;
                    CityG4.Children.Add(b);
                }
            }
        }

        public void AlsoMegjelenit()
        {
            korhaz = 0;
            lako = 0;
            penz = 0;
            boldogsag = 1;
            lakoszam();
            gyarszam();
            boltszam();
            mulatszam();
            korhazszam();
            utszam();
            betonszam();
            vasutszam();

            adatszam();
            CityG1.Children.Clear();
            CityG2.Children.Clear();
            CityG3.Children.Clear();
            CityG4.Children.Clear();
            nulla.Fill = new SolidColorBrush(Color.FromRgb(235, 235, 235));
            nullaL.Content = "'0' gomb - Road";
            egy.Fill = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            egyL.Content = "'1' gomb - Highway";
            ket.Fill = new SolidColorBrush(Color.FromRgb(170, 170, 170));
            ketL.Content = "'2' gomb - Rail";
            harom.Visibility = Visibility.Collapsed;
            haromL.Visibility = Visibility.Collapsed;
            negy.Visibility = Visibility.Collapsed;
            negyL.Visibility = Visibility.Collapsed;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button a = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    a.Width = 150;
                    a.Height = 150;
                    a.Name = "y" + i + j;
                    a.Margin = margo;
                    switch (U1[i, j])
                    {
                        case 0:
                            a.Background = new SolidColorBrush(Color.FromRgb(235, 235, 235));
                            break;
                        case 1:
                            a.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
                            break;
                        case 2:
                            a.Background = new SolidColorBrush(Color.FromRgb(170, 170, 170));
                            break;
                    }
                    a.Click += new RoutedEventHandler(also1_Click);
                    Grid.SetRow(a, i);
                    Grid.SetColumn(a, j);
                    a.HorizontalAlignment = HorizontalAlignment.Center;
                    a.VerticalAlignment = VerticalAlignment.Center;
                    CityG1.Children.Add(a);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button a = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    a.Width = 150;
                    a.Height = 150;
                    a.Name = "y" + i + j;
                    a.Margin = margo;
                    switch (U2[i, j])
                    {
                        case 0:
                            a.Background = new SolidColorBrush(Color.FromRgb(235, 235, 235));
                            break;
                        case 1:
                            a.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
                            break;
                        case 2:
                            a.Background = new SolidColorBrush(Color.FromRgb(170, 170, 170));
                            break;
                    }
                    a.Click += new RoutedEventHandler(also2_Click);
                    Grid.SetRow(a, i);
                    Grid.SetColumn(a, j);
                    a.HorizontalAlignment = HorizontalAlignment.Center;
                    a.VerticalAlignment = VerticalAlignment.Center;
                    CityG2.Children.Add(a);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button a = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    a.Width = 150;
                    a.Height = 150;
                    a.Name = "y" + i + j;
                    a.Margin = margo;
                    switch (U3[i, j])
                    {
                        case 0:
                            a.Background = new SolidColorBrush(Color.FromRgb(235, 235, 235));
                            break;
                        case 1:
                            a.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
                            break;
                        case 2:
                            a.Background = new SolidColorBrush(Color.FromRgb(170, 170, 170));
                            break;
                    }
                    a.Click += new RoutedEventHandler(also3_Click);
                    Grid.SetRow(a, i);
                    Grid.SetColumn(a, j);
                    a.HorizontalAlignment = HorizontalAlignment.Center;
                    a.VerticalAlignment = VerticalAlignment.Center;
                    CityG3.Children.Add(a);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button a = new Button();
                    Thickness margo = new Thickness(1, 1, 1, 1);
                    a.Width = 150;
                    a.Height = 150;
                    a.Name = "y" + i + j;
                    a.Margin = margo;
                    switch (U4[i, j])
                    {
                        case 0:
                            a.Background = new SolidColorBrush(Color.FromRgb(235, 235, 235));
                            break;
                        case 1:
                            a.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
                            break;
                        case 2:
                            a.Background = new SolidColorBrush(Color.FromRgb(170, 170, 170));
                            break;
                    }
                    a.Click += new RoutedEventHandler(also4_Click);
                    Grid.SetRow(a, i);
                    Grid.SetColumn(a, j);
                    a.HorizontalAlignment = HorizontalAlignment.Center;
                    a.VerticalAlignment = VerticalAlignment.Center;
                    CityG4.Children.Add(a);
                }
            }
        }

        private void also1_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (U1[sor, oszlop] != kivalasztott && kivalasztott < 3)
            {
                U1[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                AlsoMegjelenit();
            }
        }
        private void also2_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (U2[sor, oszlop] != kivalasztott && kivalasztott < 3)
            {
                U2[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                AlsoMegjelenit();
            }
        }
        private void also3_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (U3[sor, oszlop] != kivalasztott && kivalasztott < 3)
            {
                U3[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                AlsoMegjelenit();
            }
        }
        private void also4_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (U4[sor, oszlop] != kivalasztott && kivalasztott < 3)
            {
                U4[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                AlsoMegjelenit();
            }
        }
        private void varos1_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (C1[sor, oszlop] != kivalasztott)
            {
                C1[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                Megjelenit();
            }
        }
        private void varos2_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (C2[sor, oszlop] != kivalasztott)
            {
                C2[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                Megjelenit();
            }
        }
        private void varos3_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (C3[sor, oszlop] != kivalasztott)
            {
                C3[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                Megjelenit();
            }
        }
        private void varos4_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = sender as Button;
            string nev = gomb.Name;
            int sor = nev[1] - '0';
            int oszlop = nev[2] - '0';
            if (C4[sor, oszlop] != kivalasztott)
            {
                C4[sor, oszlop] = kivalasztott;
                kor++;
                korL.Content = kor + ". kör";
                Megjelenit();
            }
        }
        private void CityB_Click(object sender, RoutedEventArgs e)
        {
            Megjelenit();
        }

        private void AlsoB_Click(object sender, RoutedEventArgs e)
        {
            AlsoMegjelenit();
        }

        private void jatekablak_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.D0))
                kivalasztott = 0;
            else if (Keyboard.IsKeyDown(Key.D1))
                kivalasztott = 1;
            else if (Keyboard.IsKeyDown(Key.D2))
                kivalasztott = 2;
            else if (Keyboard.IsKeyDown(Key.D3))
                kivalasztott = 3;
            else if (Keyboard.IsKeyDown(Key.D4))
                kivalasztott = 4;
        }
    }
}
