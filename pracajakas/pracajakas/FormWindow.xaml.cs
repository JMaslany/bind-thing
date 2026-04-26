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

namespace pracajakas
{
    /// <summary>
    /// Logika interakcji dla klasy FormWindow.xaml
    /// </summary>
    public partial class FormWindow : Window
    {
        public Dane? ResData;

        public FormWindow(Dane? editData)
        {
            InitializeComponent();

            if (editData != null) 
            {
                im.Text = editData.Imie;
                na.Text = editData.Nazwisko;
                wi.Text = editData.Wiek.ToString();
                tel.Text = editData.NrTel;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResData = new Dane
            {
                Imie = im.Text.Trim(),
                Nazwisko = na.Text.Trim(),
                Wiek = int.Parse(wi.Text.Trim()),
                NrTel = tel.Text.Trim()
            };

            DialogResult = true;
        }
    }
}
