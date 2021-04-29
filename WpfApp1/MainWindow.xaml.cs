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

namespace WpfApp1
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal number1 = Convert.ToDecimal(Number1);
            decimal number2 = Convert.ToDecimal(Number2);
            string choice = select.SelectedItem.ToString();

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            decimal result = service.Calculate(number1, number2, choice);
            Result.Text = result.ToString();
        }
    }
}
