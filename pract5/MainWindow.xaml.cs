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

namespace pract5
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
        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман Валерьевич ИСП-31\nСоздать класс Triad (тройка нечетных чисел).\n Создать необходимые методы и свойства.Определить метод сравнения двух триад на равенство.\nСоздать перегруженный метод сравнения трех триад на равенство.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CompareNumber_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad triad = new Triad(int.Parse(firstTriadA.Text), int.Parse(secondTriadA.Text), int.Parse(thirdTriadA.Text));
                Triad triad1 = new Triad(int.Parse(firstTriadB.Text), int.Parse(secondTriadB.Text), int.Parse(thirdTriadB.Text));

                equal.Text = triad.CompareTwo(triad, triad1).ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompareNumber2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad triad = new Triad(int.Parse(firstTriadA.Text), int.Parse(secondTriadA.Text), int.Parse(thirdTriadA.Text));
                Triad triad1 = new Triad(int.Parse(firstTriadB.Text), int.Parse(secondTriadB.Text), int.Parse(thirdTriadB.Text));
                Triad triad2 = new Triad(int.Parse(firstTriadC.Text), int.Parse(secondTriadC.Text), int.Parse(thirdTriadC.Text));

                equal.Text = triad.CompareThree(triad, triad1, triad2).ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
