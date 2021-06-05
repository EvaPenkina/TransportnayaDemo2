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
    /// Логика взаимодействия для Zagruzki.xaml
    /// </summary>
    public partial class Zagruzki : Window
    {
        ModelBDT db = new ModelBDT();
        public Zagruzki()
        {
            InitializeComponent();
            db.Application.Load();
            Table2.ItemsSource = db.Application.Local;
        }

     
        private void BackZ_Click(object sender, RoutedEventArgs e)
        {
            Meny window = new Meny();
            window.Show();
            Close();
        }

        private void DeletZ_Click(object sender, RoutedEventArgs e)
        {
            var pp = (Application)Table2.SelectedItem;

            db.Application.Remove(pp);

            db.SaveChanges();

            Table2.ItemsSource = db.Application.OrderBy(s => s.ID_Application).ToList();
        }

        private void AddZ_Click(object sender, RoutedEventArgs e)
        {
            AddZak window = new AddZak();
            window.Show();
            Close();

        }
    }
}
