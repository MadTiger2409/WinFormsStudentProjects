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
    public partial class LoginForm : Form
    {
        private string login = "Pracownik";
        private string password = "asdf1234!";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals(login) && txtPassword.Text.Equals(password))
            {
                // Tworzymy nowy obiekt głownego okna
                MainForm mainWindow = new MainForm();

                // Pokazujemy głowne okno
                mainWindow.Show();

                // Chowamy aktualne okno
                Hide();
            }
            else
            {
                // Pokazujemy okno z informacja o błędnych danych
                MessageBox.Show("Podano nieprawidłowe dane logowania.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}