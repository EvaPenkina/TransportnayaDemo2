using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Perevozciki.xaml
    /// </summary>
    public partial class Perevozciki : Window
    {
        ModelBDT db = new ModelBDT();
        public Perevozciki()
        {
            InitializeComponent();
            db.Driver.Load();
            Table1.ItemsSource = db.Driver.Local;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddPer window = new AddPer();
            window.Show();
            Close();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Meny window = new Meny();
            window.Show();
            Close();
        }

        private void AddP_Click(object sender, RoutedEventArgs e)
        {
            AddPer window = new AddPer();
            window.Show();
            Close();
        }

        private void DeletP_Click(object sender, RoutedEventArgs e)
        {
            var pp = (Driver)Table1.SelectedItem;

            db.Driver.Remove(pp);

            db.SaveChanges();

            Table1.ItemsSource = db.Driver.OrderBy(s => s.ID_Driver).ToList();
        }

        private void BackP_Click(object sender, RoutedEventArgs e)
        {
            Meny window = new Meny();
            window.Show();
            Close();
        }
    }
}
