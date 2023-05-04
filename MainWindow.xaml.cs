﻿using System;
using System.Windows;
using System.Windows.Input;


namespace ChatAppWithWPF
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove(); //ablak mozgatasa bal egergomb lenyomas eseten
            }
        }
    }
}
