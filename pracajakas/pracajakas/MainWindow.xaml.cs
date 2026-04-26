using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
            string jsonStr = JsonSerializer.Serialize(Data);
            
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Json files (*.json)|*.json"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, jsonStr);
            }
        }

        private void MenuRead(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                List<Dane> list = JsonSerializer.Deserialize<List<Dane>>(File.ReadAllText(openFileDialog.FileName));
                foreach(Dane sd in list)
                {
                    Data.Add(sd);
                }
            }
        }

        private void AddData(object sender, RoutedEventArgs e)
        {
            FormWindow win = new FormWindow(null);

            if (win.ShowDialog() == true)
            {
                Data.Add(win.ResData);
            }
        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {
            if (DataDisplay.SelectedItem is Dane selected)
            {
                Data.Remove(selected);
            }
        }

        private void EditData(object sender, RoutedEventArgs e)
        { 
            if (DataDisplay.SelectedItem is not Dane selected)
            {
                return;
            }

            FormWindow win = new FormWindow(selected);

            if (win.ShowDialog() == true)
            {
                Data[Data.IndexOf(selected)] = win.ResData;
            }

        }
    }
}