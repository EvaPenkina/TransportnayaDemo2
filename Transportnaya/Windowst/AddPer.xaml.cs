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
    /// Логика взаимодействия для AddPer.xaml
    /// </summary>
    public partial class AddPer : Window
    {
        public AddPer()
        {
            InitializeComponent();
            db.Driver.Load();
        }
        ModelBDT db = new ModelBDT();

            Driver dr = new Driver();
        private void Back2_Click(object sender, RoutedEventArgs e)
        {

            Perevozciki window = new Perevozciki();
            window.Show();
            Close();
        }

        private void Add2_Click(object sender, RoutedEventArgs e)
        {
            dr.DriverName = NameTB.Text;

            dr.FIO_Driver = FIOTB.Text;

            dr.PassportData = PasDTB.Text;

            dr.Car = MarkTB.Text;

            dr.Trailer = Convert.ToString(NummberTB.Text);

            dr.Driver_Phone = PhoneTB.Text;

            dr.Availability = CekTB.Text;

            db.Driver.Add(dr);

            db.SaveChanges();

            Perevozciki win = new Perevozciki();

            win.Show();

            Close();
        }
    }
}
