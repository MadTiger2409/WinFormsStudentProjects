using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        // Lista ulubionych na których pracuje program
        private List<Favorite> favoritesList;

        public Form1()
        {
            InitializeComponent();
            favoritesList = new List<Favorite>(); // inicjalizacja listy ulubionych
            favoritesList = GetFavoritesFromFile(); // wczytuje ulubione z pliku
            RefreshFavoritesList(); // odświeża listę ulubionych w combo-box
        }

        private void RefreshFavoritesList()
        {
            cmbFavorites.DataSource = null; // czyścimy źródło danych z wcześniej powiązanych obiektów
            cmbFavorites.DataSource = favoritesList; // wiążemy naszą lsitę ze źródłem danych
        }

        private void AddToFavorites(string url, string title)
        {
            Favorite favorite = new Favorite(url, title); // Tworzymy nową ulubioną stronę
            favoritesList.Add(favorite); // dodajemy ulubioną na końcu listy ulubionych
            AddFavoriteToFile(favorite); // zapisanie ulubionych do pliku
            RefreshFavoritesList(); // odświeża listę ulubionych w combo-box
        }

        private void AddFavoriteToFile(Favorite favorite)
        {
            using (StreamWriter sw = new StreamWriter(@"e:\favorites.txt", true))
            {
                sw.WriteLine(string.Format("{0}|{1}", favorite.UrlAddress, favorite.Title));
            }
        }

        private List<Favorite> GetFavoritesFromFile()
        {
            // Tworzymy listę od przechowywania odczytywanych ulubionych
            List<Favorite> favorites = new List<Favorite>();

            using (StreamReader sr = new StreamReader(@"e:\favorites.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elements = line.Split('|');

                    Favorite favorite = new Favorite(elements[0], elements[1]);
                    favorites.Add(favorite);
                }
            }

            return favorites;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Sprawdzamy czy adres nie jest nullem lub nie jest pusty
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                UriBuilder builder = new UriBuilder(txtAddress.Text);
                txtAddress.Text = builder.Uri.ToString();

                // Przechodzimy pod wskazany adres
                webBrowser1.Navigate(builder.Uri);
            }
            else
            {
                // Wyświetlamy komunikat o nie podaniu adresu
                MessageBox.Show("Proszę podać adres strony!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtAddress.Text = webBrowser1.Url.ToString();

            btnNext.Enabled = webBrowser1.CanGoForward;
            btnBack.Enabled = webBrowser1.CanGoBack;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            string url = txtAddress.Text;
            string title = webBrowser1.Document.Title;

            AddToFavorites(url, title);
        }

        private void favList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Favorite favorite = cmbFavorites.SelectedItem as Favorite;
            txtAddress.Text = favorite.UrlAddress;
            webBrowser1.Navigate(favorite.UrlAddress);
        }
    }
}