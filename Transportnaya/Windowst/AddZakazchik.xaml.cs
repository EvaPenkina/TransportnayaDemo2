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
    /// Логика взаимодействия для AddZakazchik.xaml
    /// </summary>
    public partial class AddZakazchik : Window
    {
        ModelBDT db = new ModelBDT();
        public AddZakazchik()
        {
            InitializeComponent();
        }

        private void Back4_Click(object sender, RoutedEventArgs e)
        {
            Zakazchiki window = new Zakazchiki();
            window.Show();
            Close();
        }

        private void Add4_Click(object sender, RoutedEventArgs e)
        {
            Client dr = new Client();

            dr.Client_name = NameTVB.Text;

            dr.Client_address = YorTB.Text;

            dr.Client_IMX = Convert.ToInt32(INNTB.Text);

            dr.Client_KPP = Convert.ToInt32(KPPTB.Text);

            dr.Client_phone = Convert.ToInt32(PhonTB.Text);

            dr.Client_BankAccount = Convert.ToInt32(BancScetTB.Text);

            dr.Client_OGRN = Convert.ToInt32(OGRNTB.Text);

            dr.Bank_name = NameBanTB.Text;

            dr.BIK = Convert.ToInt32(BIKTB.Text);

            dr.ContactPerson = KontracTB.Text;

            db.Client.Add(dr);

            db.SaveChanges();

            Zakazchiki win = new Zakazchiki();

            win.Show();

            Close();
        }
    }
}
