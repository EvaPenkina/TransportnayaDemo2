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

namespace Transportnaya.Windowst
{
    /// <summary>
    /// Логика взаимодействия для Meny.xaml
    /// </summary>
    public partial class Meny : Window
    {
        public Meny()
        {
            InitializeComponent();
        }

        private void Perevoz_Click(object sender, RoutedEventArgs e)
        {
            Perevozciki window = new Perevozciki();
            window.Show();
            Close();
                
        }

        private void Zagruzki_Click(object sender, RoutedEventArgs e)
        {
            Zagruzki window = new Zagruzki();
            window.Show();
            Close();
        }

        private void Zacazchiki_Click(object sender, RoutedEventArgs e)
        {
            Zakazchiki window = new Zakazchiki();
            window.Show();
            Close();
        }

        private void Close2_Click(object sender, RoutedEventArgs e)
        {
            Avtorizaciya window = new Avtorizaciya();
            window.Show();
            Close();
        }
    }
}
