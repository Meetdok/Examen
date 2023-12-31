﻿using Examen.VM;
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
using System.Windows.Shapes;

namespace Examen
{
    /// <summary>
    /// Логика взаимодействия для AddGames.xaml
    /// </summary>
    public partial class AddGames : Window
    {
        public AddGames()
        {
            InitializeComponent();
            DataContext = new AddGamesVM();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
