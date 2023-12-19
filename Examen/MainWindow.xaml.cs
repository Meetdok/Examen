using Examen.VM;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new GamesList();
        }

        private void AddForm(object sender, RoutedEventArgs e)
        {
            AddGames a = new AddGames();
            a.Show();
            this.Close();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            MainWindow m  = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
