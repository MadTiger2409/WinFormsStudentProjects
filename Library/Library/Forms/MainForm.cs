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
    public partial class MainForm : Form
    {
        private GameLibrary library;

        public MainForm()
        {
            InitializeComponent();
            library = new GameLibrary();
            library.ImportGamesFromFile();
            lblGames.DataSource = library.GetGames();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();
            newGameForm.ShowDialog();

            library.ImportGamesFromFile();

            lblGames.DataSource = null;
            lblGames.DataSource = library.GetGames();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            library.RemoveGame(lblGames.SelectedItem as GameObject);
            lblGames.DataSource = null;
            lblGames.DataSource = library.GetGames();
        }
    }
}