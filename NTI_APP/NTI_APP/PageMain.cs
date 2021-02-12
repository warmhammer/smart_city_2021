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
    public partial class PageMain : UserControl
    {
        public PageMain()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerCounter >= images.Length)
            {
                timerCounter = 0;
            }

            this.SliderBox1MainPage.BackgroundImage =images[timerCounter] ;

            timerCounter++;

        }

   
    }
}
