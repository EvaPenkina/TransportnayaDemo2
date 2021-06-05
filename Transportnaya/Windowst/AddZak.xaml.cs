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
    /// Логика взаимодействия для AddZak.xaml
    /// </summary>
    public partial class AddZak : Window
    {
        ModelBDT db = new ModelBDT();
        public AddZak()
        {
            InitializeComponent();
        }


        private void Back3_Click(object sender, RoutedEventArgs e)
        {
            Zagruzki window = new Zagruzki();
            window.Show();
            Close();
        }

        private void Add3_Click(object sender, RoutedEventArgs e)
        {
            Application dr = new Application();

            dr.ID_Application = NameTBV.Text;

            dr.ID_Driver = Name2TB.Text;

            dr.ID_Client = Name3TB.Text;

            dr.Cargo_Name = NameGTB.Text;

            dr.Charge_address = Mape2TB.Text;

            dr.Charge_date = Convert.ToInt32(DataTB.Text);

            dr.Discharge_address = Mape3TB.Text;

            dr.Discharge_date = Convert.ToInt32(Data3TB.Text);

            dr.ReqTypeRollingStock = Mark2TB.Text;

            dr.Cargo_weight = VesTB.Text;

            dr.Cost = Convert.ToInt32(SummaTB.Text);

            db.Application.Add(dr);

            db.SaveChanges();

            Zagruzki win = new Zagruzki();

            win.Show();

            Close();
        }
    }
}
