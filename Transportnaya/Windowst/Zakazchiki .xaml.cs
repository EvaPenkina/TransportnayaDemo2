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
    /// Логика взаимодействия для Zakazchiki.xaml
    /// </summary>
    public partial class Zakazchiki : Window
    {
        ModelBDT db = new ModelBDT();
        public Zakazchiki()
        {
            InitializeComponent();
            db.Client.Load();
            Table3.ItemsSource = db.Client.Local;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddZakazchik window = new AddZakazchik();
            window.Show();
            Close();
        }

        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            var pp = (Client)Table3.SelectedItem;

            db.Client.Remove(pp);

            db.SaveChanges();

            Table3.ItemsSource = db.Client.OrderBy(s => s.ID_Client).ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Meny window = new Meny();
            window.Show();
            Close();
        }
    }
}
