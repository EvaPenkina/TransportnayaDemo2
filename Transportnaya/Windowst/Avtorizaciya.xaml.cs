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
using Transportnaya.BD_Model;

namespace Transportnaya.Windowst
{
    /// <summary>
    /// Логика взаимодействия для Avtorizaciya.xaml
    /// </summary>
    public partial class Avtorizaciya : Window
    {
        ModelBDT db = new ModelBDT();
        public Avtorizaciya()
        {
            InitializeComponent();
        }

        private void Voiti_Click(object sender, RoutedEventArgs e)
        {

                if (db.Avtorizac.Where(u => u.Login == loginTV.Text && u.Password == passwordTV.Password).FirstOrDefault() != null)
                {
                Meny window = new Meny();
                window.Show();
                Close();
                }
            else

            {

                MessageBox.Show("Неверный логин или пароль!");

            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
