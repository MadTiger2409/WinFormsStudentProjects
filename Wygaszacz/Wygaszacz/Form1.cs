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

namespace Wygaszacz
{
    public partial class Form1 : Form
    {
        // Przechowują informacje o pozycji kursora
        private int x, y;

        private string[] sciezkiDoObrazow;
        private int iloscObrazkow;
        private int numerObrazka;

        public Form1()
        {
            InitializeComponent();
            x = 0;
            y = 0;
            iloscObrazkow = 0;
            numerObrazka = 0;
        }

        private void MouseMove1(object sender, MouseEventArgs e)
        {
            if (e.X != x || e.Y != y)
            {
                Application.Exit();
            }
        }

        private void StoperTick(object sender, EventArgs e)
        {
            try
            {
                BackgroundImage = Image.FromFile(sciezkiDoObrazow[numerObrazka++]);

                if (numerObrazka == iloscObrazkow)
                {
                    numerObrazka = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd w trakcie pobierania pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            // Pobranie danych kursora
            x = Cursor.Position.X;
            y = Cursor.Position.Y;

            string folder = @"C:\Users\Cyber\Pictures\Cars";

            try
            {
                sciezkiDoObrazow = Directory.GetFiles(folder);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd w trakcie pobierania obrazków!");
                Application.Exit();
            }

            iloscObrazkow = sciezkiDoObrazow.Length;

            if (iloscObrazkow == 0)
            {
                MessageBox.Show("Brak obrazków w folderze!");
                Application.Exit();
            }

            // Ustawiamy tło na pierwszy obrazek z tablicy
            BackgroundImage = Image.FromFile(sciezkiDoObrazow[numerObrazka]);

            Cursor.Hide(); // Ukryj kursor
            WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void MouseClick1(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void KeyDown1(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}