using Examen.DB;
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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Sign(object sender, RoutedEventArgs e)
        {
            var auth = Rey_InterpriseContext.GetInstance().Users.FirstOrDefault(s => s.Login == txt_login.Text && s.Password == txt_password.Text);

            if (auth == null)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                MainWindow m = new MainWindow();
                m.Show();
                this.Close();
            }


        }
    }
}
