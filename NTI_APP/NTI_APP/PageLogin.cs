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

namespace NTI_APP
{


   public partial class PageLogin : UserControl
    {
        public PageLogin(MySqlConnection conn)
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

        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationLinkClicked.Invoke(sender, e);
        }

        private void EnteryButton_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password =  textBoxPassword.Text ;

            

            string sql = "SELECT `password` from user where email =" + "'" + email + "'";
            MySqlCommand command = new MySqlCommand (sql, conn);

            string pass;

            if (command.ExecuteScalar() != null)
            { 
               pass = command.ExecuteScalar().ToString();
                if (pass == password)
                {
                    auth = new pageAuth(email);
                    EnterSuccess.Invoke(sender, e);
                }
                else
                {
                    string error = "Wrong password";
                    labelError.Text = error;
                }
            }
            else
            {
                string error = "E-mail doesn't exist";
                labelError.Text = error;
            }
        }

    }
}
