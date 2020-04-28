using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfrCezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSecure_Click(object sender, EventArgs e)
        {
            string textToSecure = txtTextToSecure.Text;
            int movePosition = (int)numMovePosition.Value;
            string textSecured = Secure(textToSecure, movePosition);

            txtTextSecured.Text = textSecured;
        }

        private string Secure(string textToSecure, int movePosition)
        {
            // zamieniamy string na tablicę typu char - tablicę znaków
            char[] buffor = textToSecure.ToCharArray();

            // iterujemy po każdym znaku
            for (int i = 0; i < buffor.Length; i++)
            {
                // czytamy konkretny znak
                char character = buffor[i];

                // pomijamy spacje, kropki i przecinki
                if (character == ' ' || character == '.' || character == ',')
                {
                    continue;
                }

                // jeżeli nasz znak znajduje się w zbiorze wielkich liter
                if (character >= 'A' && character <= 'Z')
                {
                    // wykonujemy przesunięcie
                    character = (char)(character + movePosition);

                    if (character > 'Z')
                    {
                        // jeśli wyjdzie poza zakres z prawej strony to musimy
                        // odjąć 26 aby wrócić do zakresu od A do Z
                        character = (char)(character - 26);
                    }
                    else if (character < 'A')
                    {
                        character = (char)(character + 26);
                    }
                }
                else if (character >= 'a' && character <= 'z')
                {
                    character = (char)(character + movePosition);

                    if (character > 'z')
                    {
                        character = (char)(character - 26);
                    }
                    else if (character < 'a')
                    {
                        character = (char)(character + 26);
                    }
                }
                else
                {
                    character = ' ';
                }
                buffor[i] = character;
            }

            buffor = Array.FindAll(buffor, IsNotWtiheSpace).ToArray();

            return new string(buffor);
        }

        private bool IsNotWtiheSpace(char x)
        {
            return !char.IsWhiteSpace(x);
        }
    }
}