using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace bindingDoKlas
{
    public partial class ListaAlbumów : Window
    {
        public ObservableCollection<Album> Albumy { get; } = new ObservableCollection<Album>();
        ListBox lista;

        public ListaAlbumów()
        {
            DataContext = this;
            InitializeComponent();
            lista = (ListBox)FindName("Lista");
        }

        private void Edytuj(object sender, RoutedEventArgs e)
        {
            Album wybrany = (Album)lista.SelectedItem;
            if (wybrany != null)
                new WidokAlbumu(wybrany).Show();
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            Album nowy = new Album();
            Albumy.Add(nowy);
            new WidokAlbumu(nowy).Show();
        }

        private void Usuń(object sender, RoutedEventArgs e)
        {
            Album wybrany = (Album)lista.SelectedItem;
            Albumy.Remove(wybrany);
        }

        private void Importuj(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.DefaultExt = ".json";
            openFileDialog.Filter = "Pliki JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog() == true)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                var importedAlbumy = JsonConvert.DeserializeObject<List<Album>>(json);

                if (importedAlbumy != null)
                {
                    Albumy.Clear();
                    foreach (var album in importedAlbumy)
                    {
                        Albumy.Add(album);
                    }
                }
            }
        }

        private void Eksportuj(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.DefaultExt = ".json";
            saveFileDialog.Filter = "Pliki JSON (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == true)
            {
                string json = JsonConvert.SerializeObject(Albumy.ToList(), Formatting.Indented);
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
    }
}
