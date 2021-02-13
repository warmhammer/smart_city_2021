using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace NTI_APP
{
    public partial class pageAuth : UserControl
    {
        public pageAuth(string email)
        {
            InitializeComponent();

            sendEmail(email);
        }

        private void EnteryLabel_Click(object sender, EventArgs e)
        {

        }

        private void EnteryButton_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == code.ToString())
            {
                authSuccess.Invoke(sender, e);
            }
            else
            {
                labelError.Text = "Wrong code";
            }
        }

        private void sendEmail(string email)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("gnosepetro@yandex.ru", "Система умного предприятия");
            mail.To.Add(new MailAddress(email));
            // тема письма
            mail.Subject = "Код системы умного предприятия";

            Random rand = new Random();
            this.code = rand.Next(100000, 999999);
            // текст письма
            mail.Body = "<h2>Ваш код для входа: " + this.code + "</h2>";
            // письмо представляет код html
            mail.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("gnosepetro@yandex.ru", "ndhzarxnucrqojeu");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
