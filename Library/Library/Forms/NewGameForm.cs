using Library.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtAgeMin.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GameObject game = new GameObject(decimal.Parse(txtPrice.Text), txtTitle.Text, txtDescription.Text,
                int.Parse(txtAgeMin.Text));

                game.SaveToFile();

                MessageBox.Show("Zapisano grę!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Podano błędne dane: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}