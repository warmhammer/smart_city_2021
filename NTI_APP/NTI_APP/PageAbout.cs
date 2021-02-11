using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Reflection;

namespace NTI_APP
{
    public partial class PageAbout : UserControl
    {
        public PageAbout()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //var url = "mailto:someone@somewhere.com";
            //Process.Start(url);
            //"mailto:" + to + "&SUBJECT=" + subject + "?BODY=" + body + "&Attachment=" + attachment
            //System.Diagnostics.Process.Start("mailto:bla@bla.bla");

            //string subject = "Test subject";
            //string emailTag = string.Format("mailto:someone@test.com?subject={0}", subject);
            //System.Diagnostics.Process.Start(emailTag);

            string target = "http://www.microsoft.com";
            //Use no more than one assignment when you test this code.
            //string target = "ftp://ftp.microsoft.com";
            //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

            /*
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("someone@yourdomain.com");
            mailMessage.Subject = "Your subject here";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<span style='font-size: 12pt; color: red;'>My HTML formatted body</span>";

            mailMessage.Attachments.Add(new Attachment("C://Myfile.pdf"));

            var filename = "C://Temp/mymessage.eml";

            //save the MailMessage to the filesystem
            mailMessage.Save(filename);

            //Open the file with the default associated application registered on the local machine
            Process.Start(mailMessage);
            */
        }
    }
}
