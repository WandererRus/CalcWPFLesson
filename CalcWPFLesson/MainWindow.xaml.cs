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

namespace CalcWPFLesson
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

        private void btn_zero_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "0";
        }

        private void btn_one_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "1";
        }

        private void btn_two_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "2";
        }

        private void btn_three_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "3";
        }

        private void btn_four_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "4";
        }

        private void btn_five_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "5";
        }

        private void btn_six_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "6";
        }

        private void btn_seven_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "7";
        }

        private void btn_eight_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "8";
        }

        private void btn_nine_Click(object sender, RoutedEventArgs e)
        {
            tb_currentResult.Text += "9";
        }

        private void btn_point_Click(object sender, RoutedEventArgs e)
        {
            if (tb_currentResult.Text.Length != 0)
            {
                tb_currentResult.Text += ".";
            }
            else
            {
                tb_currentResult.Text += "0.";
            }
        }
    }
}
