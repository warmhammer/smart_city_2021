using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTI_APP
{
    public partial class PageLogin : UserControl
    {
        public PageLogin()
        {
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
            //Nikite suda

            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            //Success
            EnterSuccess.Invoke(sender, e);

            //Failure
        }
    }
}
