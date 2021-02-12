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
            //TODO
            ProcessStartInfo procInfo = new ProcessStartInfo(@"mailto:info@mail.ru");

            procInfo.UseShellExecute = true;
            Process.Start(procInfo);
        }

        private void labelMail2_Click(object sender, EventArgs e)
        {
            //TODO
            ProcessStartInfo procInfo = new ProcessStartInfo(@"mailto:info@mail.ru");

            procInfo.UseShellExecute = true;
            Process.Start(procInfo);
        }

        private void labelAddress1_Click(object sender, EventArgs e)
        {
            //TODO
            ProcessStartInfo procInfo = new ProcessStartInfo(@"https://yandex.ru/maps/213/moscow/search/г.Караганда, ул.Гоголя, 34А/");

            procInfo.UseShellExecute = true;
            Process.Start(procInfo);
        }

        private void labelAddress2_Click(object sender, EventArgs e)
        {
            //TODO
            ProcessStartInfo procInfo = new ProcessStartInfo(@"https://yandex.ru/maps/213/moscow/search/г.Караганда, ул.Гоголя, 34А/");

            procInfo.UseShellExecute = true;
            Process.Start(procInfo);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //TODO
            ProcessStartInfo procInfo = new ProcessStartInfo(@"ms-phone:8-(999)-999-99-99");

            procInfo.UseShellExecute = true;
            Process.Start(procInfo);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //TODO
            ProcessStartInfo procInfo = new ProcessStartInfo(@"ms-phone:8-(999)-999-99-99");

            procInfo.UseShellExecute = true;
            Process.Start(procInfo);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DimGray;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DimGray;
        }

        private void labelMail1_MouseEnter(object sender, EventArgs e)
        {
            labelMail1.ForeColor = Color.Black;
        }

        private void labelMail1_MouseLeave(object sender, EventArgs e)
        {
            labelMail1.ForeColor = Color.DimGray;
        }

        private void labelAddress1_MouseEnter(object sender, EventArgs e)
        {
            labelAddress1.ForeColor = Color.Black;
        }

        private void labelAddress1_MouseLeave(object sender, EventArgs e)
        {
            labelAddress1.ForeColor = Color.DimGray;
        }

        private void labelAddress2_MouseEnter(object sender, EventArgs e)
        {
            labelAddress2.ForeColor = Color.Black;
        }

        private void labelAddress2_MouseLeave(object sender, EventArgs e)
        {
            labelAddress2.ForeColor = Color.DimGray;
        }

        private void labelMail2_MouseEnter(object sender, EventArgs e)
        {
            labelMail2.ForeColor = Color.Black;
        }

        private void labelMail2_MouseLeave(object sender, EventArgs e)
        {
            labelMail2.ForeColor = Color.DimGray;
        }
    }
}
