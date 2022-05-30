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
        int kivalasztott, lako, kor, gyar, korhaz, vasut, mulat = 0;
        double pont, penz, jovedelem = 0;
        double boldogsag = 1;
        public void achcheck() //nincs még meghívva
        {
            if (vasut > 200)
            {
                File.WriteAllText("vasut.txt", "true");
            }
        }
        public void pontszam()
        {
            //Nem néztem jobban bele, de egyszer negatív jövedelemmel és boldogsággal pozitív eredmény jött ki
            pont = Math.Round(penz + 0.7 * jovedelem + boldogsag + lako,2);
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
                        mulat++;
                        boldogsag++;
                    }
                    if (C2[i, j] == 3)
                    {
                        mulat++;
                        boldogsag++;
                    }
                    if (C3[i, j] == 3)
                    {
                        mulat++;
                        boldogsag++;
                    }
                    if (C4[i, j] == 3)
                    {
                        mulat++;
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
                boldogsag += (korhaz - 3) * 0.1;
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
                        boldogsag += 0.1;
                        if (i >= 1 && U1[i - 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j >= 1 && U1[i, j - 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (i < 8 && U1[i + 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j < 8 && U1[i, j + 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                    }
                    if (U2[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.1;
                        if (i >= 1 && U2[i - 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j >= 1 && U2[i, j - 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (i < 8 && U2[i + 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j < 8 && U2[i, j + 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                    }
                    if (U3[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.1;
                        if (i >= 1 && U3[i - 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j >= 1 && U3[i, j - 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (i < 8 && U3[i + 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j < 8 && U3[i, j + 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                    }
                    if (U4[i, j] == 1)
                    {
                        penz -= 200;
                        boldogsag += 0.1;
                        if (i >= 1 && U4[i - 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j >= 1 && U4[i, j - 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (i < 8 && U4[i + 1, j] == 1)
                        {
                            boldogsag += 0.1;
                        }
                        if (j < 8 && U4[i, j + 1] == 1)
                        {
                            boldogsag += 0.1;
                        }
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
                        boldogsag += 0.2;
                        if (i >= 1 && U1[i-1,j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j >= 1 && U1[i, j-1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (i < 8 && U1[i + 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j < 8 && U1[i, j+1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                    }
                    if (U2[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.2;
                        if (i >= 1 && U2[i - 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j >= 1 && U2[i, j - 1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (i < 8 && U2[i + 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j < 8 && U2[i, j + 1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                    }
                    if (U3[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.2;
                        if (i >= 1 && U3[i - 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j >= 1 && U3[i, j - 1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (i < 8 && U3[i + 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j < 8 && U3[i, j + 1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                    }
                    if (U4[i, j] == 2)
                    {
                        vasut++;
                        penz -= 400;
                        boldogsag += 0.2;
                        if (i >= 1 && U4[i - 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j >= 1 && U4[i, j - 1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (i < 8 && U4[i + 1, j] == 2)
                        {
                            boldogsag += 0.2;
                        }
                        if (j < 8 && U4[i, j + 1] == 2)
                        {
                            boldogsag += 0.2;
                        }
                    }
                }
            }
        }
        public void szamok()
        {
            living.Content = lako;
            industrial.Content = gyar;
            commercial.Content = jovedelem;
            entertainment.Content = mulat;
            medical.Content = korhaz;
            livingS.Value = lako;
            industrialS.Value = gyar;
            commercialS.Value = jovedelem;
            entertainmentS.Value = mulat;
            medicalS.Value = korhaz;
            StreamReader sr = new StreamReader("highscore.txt");
            double highscore = Convert.ToDouble(sr.ReadLine());
            highscoreL.Content = highscore;
        }
        public void Megjelenit()
        {
            CityG1.Children.Clear();
            CityG2.Children.Clear();
            CityG3.Children.Clear();
            CityG4.Children.Clear();
            nulla.Background = new ImageBrush(new BitmapImage(new Uri("living.png", UriKind.Relative)));
            nullaL.Content = "'0' gomb - Living";
            egy.Background = new ImageBrush(new BitmapImage(new Uri("industrial.png", UriKind.Relative)));
            egyL.Content = "'1' gomb - Industrial";
            ket.Background = new ImageBrush(new BitmapImage(new Uri("commercial.png", UriKind.Relative)));
            ketL.Content = "'2' gomb - Commercial";
            harom.Background = new ImageBrush(new BitmapImage(new Uri("entertainment.png", UriKind.Relative)));
            haromL.Content = "'3' gomb - Entertainment";
            negy.Background = new ImageBrush(new BitmapImage(new Uri("hospital.png", UriKind.Relative)));
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
            //mulat = 0;
            //jovedelem = 0;
            //gyar = 0;
            //korhaz = 0;
            //lako = 0;
            //boldogsag = 1;
            //lakoszam();
            //gyarszam();
            //boltszam();
            //mulatszam();
            //korhazszam();
            //utszam();
            //betonszam();
            //vasutszam();
            //szamok();
            //adatszam();
            //pontszam();
            CityG1.Children.Clear();
            CityG2.Children.Clear();
            CityG3.Children.Clear();
            CityG4.Children.Clear();
            nulla.Background = new SolidColorBrush(Color.FromRgb(235, 235, 235));
            nullaL.Content = "'0' gomb - Road";
            egy.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            egyL.Content = "'1' gomb - Highway";
            ket.Background = new SolidColorBrush(Color.FromRgb(170, 170, 170));
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);

                    }
                    sw.Close();
                }
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                }
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                }
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                }
            }
        }

        private void nulla_Click(object sender, RoutedEventArgs e)
        {
            kivalasztott = 0;
        }

        private void egy_Click(object sender, RoutedEventArgs e)
        {
            kivalasztott = 1;
        }

        private void ket_Click(object sender, RoutedEventArgs e)
        {
            kivalasztott = 2;
        }

        private void harom_Click(object sender, RoutedEventArgs e)
        {
            kivalasztott = 3;
        }

        private void negy_Click(object sender, RoutedEventArgs e)
        {
            kivalasztott = 4;
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                }
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                }
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                }
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
                mulat = 0;
                jovedelem = 0;
                gyar = 0;
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
                szamok();
                adatszam();
                pontszam();
                if (kor >= 100)
                {
                    MessageBox.Show($"Vége a játéknak.\nPontszám: {pont} ");
                    StreamReader sr = new StreamReader("highscore.txt");
                    double highscore = Convert.ToDouble(sr.ReadLine());
                    sr.Close();
                    StreamWriter sw = new StreamWriter("highscore.txt");
                    if (pont > highscore)
                    {
                        sw.WriteLine(pont);
                    }
                    sw.Close();
                    StreamWriter sw2 = new StreamWriter("highscore.txt");
                    sw.Close();
                }
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

        private void help_Click(object sender, RoutedEventArgs e)
        {
            Segitseg subWindow = new Segitseg();
            subWindow.Show();
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
