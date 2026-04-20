using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pracajakas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Dane> Data = new ObservableCollection<Dane>();

        public MainWindow()
        {
            InitializeComponent();
            DataDisplay.ItemsSource = Data;
        }

        private void MenuSave(object sender, RoutedEventArgs e)
        {

        }

        private void MenuRead(object sender, RoutedEventArgs e)
        {

        }

        private void AddData(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {

        }

        private void EditData(object sender, RoutedEventArgs e)
        {

        }
    }
}