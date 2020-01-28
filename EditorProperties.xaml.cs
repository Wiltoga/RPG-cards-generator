﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPGcardsGenerator
{
    /// <summary>
    /// Logique d'interaction pour EditorProperties.xaml
    /// </summary>
    public partial class EditorProperties : Window
    {
        public EditorProperties()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Options().ShowDialog();
        }
    }
}