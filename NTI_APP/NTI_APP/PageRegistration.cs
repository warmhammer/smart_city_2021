using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace NTI_APP
{
    public partial class PageRegistration : UserControl
    {
        public PageRegistration(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }
        private void linkLabelRegistration_Click(object sender, EventArgs e)
        {

        }

     

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void linkWastePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginLinkClicked.Invoke(sender, e);
        }

        private void EnteryButton_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (!isEmail(email))
            {
                string error = "Wrong e-mail";
                labelError.Text = error;
                return;
            }

            string password = textBoxPassword.Text;


            string errorMessage = "";

            int points = 0;

            if (password.Length < 8 )
            {
                errorMessage += "Меньше 8-ми символов/"; 
                points++;
            }
            if (password.Length > 20)
            {
                errorMessage += "Больше 20-ти символов/";
                points++;
            }

            if (!password.Any(c => char.IsUpper(c)))
            {
                errorMessage += "Отсутствуют заглавные буквы/";
                points++;
            }
            if (!password.Any(c => char.IsDigit(c)))
            {
                errorMessage += "Отстутствуют цифры/"; 
                points++;
            }
            if (!password.Any(c => char.IsPunctuation(c)))
            {
                errorMessage += "Отстутствуют знаки препинания";
                points++;
            }

            if (points == 0)
            {
                string sql = "SELECT 'ID' FROM user WHERE email =" + "'" + email + "'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                if (command.ExecuteScalar() == null)
                {
                    string sql0 = "SELECT MAX(id) FROM user";
                    MySqlCommand command0 = new MySqlCommand(sql0, conn);
                    string maxid = command0.ExecuteScalar().ToString();

                    int ID = Convert.ToInt32(maxid);
                    ID++;
                    String newID = (ID).ToString();


                    //Insert a user data
                    string v1 = newID; //ID
                    string v2 = "0"; //ADMIN FLAG
                    string v3 = "'user" + newID + "'";//username
                    string v4 = "'" + email + "'";//usermail
                    string v5 = "'" + password + "'"; //password
                    string v6 = "000000"; //mailcode
                    string sql2 = "Insert into user values (" + v1 + "," + v2 + "," + v3 + "," + v4 + "," + v5 + "," + v6 + ");";
                    MySqlCommand command2 = new MySqlCommand(sql2, conn);
                    command2.ExecuteNonQuery();

                    sendEmail(email);
                    RegistrationSuccess.Invoke(sender, e);
                }
                else
                {
                    labelError.Text = "User is already registreted";
                }
            }
            else
            {
                labelError.Text = errorMessage;
            }
        }
       
        private bool isEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email.ToLower(), pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void sendEmail(string email)
        { 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("gnosepetro@yandex.ru", "Система умного предприятия");
            mail.To.Add(new MailAddress(email));
            // тема письма
            mail.Subject = "Успешная регистрация";
            // текст письма
            mail.Body = "<h2>Здравствуйте! Пользователь с вашей почтой успешно зарегистрировался в системе умного предприятия</h2>";
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
