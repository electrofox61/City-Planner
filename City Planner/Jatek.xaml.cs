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
        int penz = 0;
        int kor = 0;
        double boldogsag = 1;
        int korhaz = 0;
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
                        boldogsag -= 0.25;
                    }
                    if (C2[i, j] == 1)
                    {
                        boldogsag -= 0.25;
                    }
                    if (C3[i, j] == 1)
                    {
                        boldogsag -= 0.25;
                    }
                    if (C4[i, j] == 1)
                    {
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
                        penz++;
                    }
                    if (C2[i, j] == 2)
                    {
                        penz++;
                    }
                    if (C3[i, j] == 2)
                    {
                        penz++;
                    }
                    if (C4[i, j] == 2)
                    {
                        penz++;
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
        public void iskolaszam()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (C1[i, j] == 5)
                    {
                    }
                    if (C2[i, j] == 5)
                    {
                    }
                    if (C3[i, j] == 5)
                    {
                    }
                    if (C4[i, j] == 5)
                    {
                    }
                }
            }
        }
        public void Megjelenit()
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
            iskolaszam();
            CityG1.Children.Clear();
            CityG2.Children.Clear();
            CityG3.Children.Clear();
            CityG4.Children.Clear();
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
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        case 1:
                            b.Background = new SolidColorBrush(Color.FromRgb(80, 40, 0));
                            break;
                        case 2:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                            break;
                        case 3:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 100, 0));
                            break;
                        case 4:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            break;
                        case 5:
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
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
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            
                            break;
                        case 1:
                            b.Background = new SolidColorBrush(Color.FromRgb(80, 40, 0));
                            break;
                        case 2:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                            
                            break;
                        case 3:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 100, 0));
                            break;
                        case 4:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            
                            break;
                        case 5:
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                            
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
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            
                            break;
                        case 1:
                            b.Background = new SolidColorBrush(Color.FromRgb(80, 40, 0));
                            break;
                        case 2:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                            
                            break;
                        case 3:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 100, 0));
                            break;
                        case 4:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            
                            break;
                        case 5:
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                            
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
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            
                            break;
                        case 1:
                            b.Background = new SolidColorBrush(Color.FromRgb(80, 40, 0));
                            break;
                        case 2:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 255, 0));
                            
                            break;
                        case 3:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 100, 0));
                            break;
                        case 4:
                            b.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            
                            break;
                        case 5:
                            b.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                            
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
            boldogsagL.Content = Math.Round(boldogsag,2);
            if (boldogsag == 0)
                boldogsag = 0.1;
            penzL.Content = Math.Round(penz * boldogsag,2);
            lakoL.Content = lako;
        }

        public void AlsoMegjelenit()
        {
            CityG1.Children.Clear();
            CityG2.Children.Clear();
            CityG3.Children.Clear();
            CityG4.Children.Clear();
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
            }
            AlsoMegjelenit();
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
            }
            AlsoMegjelenit();
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
            }
            AlsoMegjelenit();
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
            }
            AlsoMegjelenit();
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
            }
            Megjelenit();
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
            }
            Megjelenit();
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
            }
            Megjelenit();
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
            }
            Megjelenit();
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
            else if (Keyboard.IsKeyDown(Key.D5))
                kivalasztott = 5;
        }
    }
}