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
using pacini_asyncsocketserver;

namespace pacini_async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml  sdvesfwefea
    /// </summary>
    public partial class MainWindow : Window
    {
        AsyncSocketServer mServer;
        public MainWindow()
        {
            InitializeComponent();
            mServer = new AsyncSocketServer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mServer.InAscolto();
        }
    }
}
