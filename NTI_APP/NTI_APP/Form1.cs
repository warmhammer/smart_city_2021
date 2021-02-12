using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace NTI_APP
{
    public partial class MainForm : Form
    {
        public MainForm(System.Diagnostics.Process factoryIOProcess, MySqlConnection conn)
        {
            this.factoryIOProcess = factoryIOProcess;
            this.conn = conn;

            this.pageLogin = new PageLogin(conn);
            this.pageLogin.RegistrationLinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pageLoginRegistration_Click);
            this.pageLogin.EnterSuccess += new System.EventHandler(this.pageLoginEnterSuccess);
            this.pageAccount = new PageAccount();

            this.pageRegistration = new PageRegistration();
            this.pageRegistration.LoginLinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pageRegistrationLogin_Click);


            this.pageMain = new PageMain();
            this.pageVideo = new PageVideo(factoryIOProcess);
            this.pageAbout = new PageAbout();
            this.pageMain.KnoweledgeMore += new System.EventHandler(this.pageMainKnowMore_Click);

            InitializeComponent();
        }

        ~MainForm()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", toolStripMenuItemAccount, e.ClickedItem);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "ItemClicked Event");
            */

            if (e.ClickedItem == toolStripMenuItemMain)
            {
                this.tableLayoutPanelPagePlace.Controls.Clear();
                this.pageMain.Dock = System.Windows.Forms.DockStyle.None;
                this.pageMain.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.tableLayoutPanelPagePlace.Controls.Add(this.pageMain, 0, 0);
            }
            if (e.ClickedItem == toolStripMenuItemAccount)
            {
                if (!loginFlag)
                {
                    this.tableLayoutPanelPagePlace.Controls.Clear();
                    this.pageLogin.Dock = System.Windows.Forms.DockStyle.None;
                    this.pageLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.tableLayoutPanelPagePlace.Controls.Add(this.pageLogin, 0, 0);
                }
                else
                {
                    this.tableLayoutPanelPagePlace.Controls.Clear();
                    this.pageAccount.Dock = System.Windows.Forms.DockStyle.None;
                    this.pageAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.tableLayoutPanelPagePlace.Controls.Add(this.pageAccount, 0, 0);
                }
            }
            if (e.ClickedItem == toolStripMenuItemAbout)
            {
                this.tableLayoutPanelPagePlace.Controls.Clear();
                this.pageAbout.Dock = System.Windows.Forms.DockStyle.None;
                this.pageAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.tableLayoutPanelPagePlace.Controls.Add(this.pageAbout, 0, 0);
            }
            if (e.ClickedItem == toolStripMenuItemVideo)
            {
                this.tableLayoutPanelPagePlace.Controls.Clear();
                this.pageVideo.Dock = System.Windows.Forms.DockStyle.None;
                this.pageVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.tableLayoutPanelPagePlace.Controls.Add(this.pageVideo, 0, 0);
            }
        }

        private void pageLoginRegistration_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tableLayoutPanelPagePlace.Controls.Clear();
            this.pageRegistration.Dock = System.Windows.Forms.DockStyle.None;
            this.pageRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelPagePlace.Controls.Add(this.pageRegistration, 0, 0);
        }

        private void pageLoginEnterSuccess(object sender, EventArgs e)
        {
            loginFlag = true; 

            this.tableLayoutPanelPagePlace.Controls.Clear();
            this.pageAccount.Dock = System.Windows.Forms.DockStyle.None;
            this.pageAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelPagePlace.Controls.Add(this.pageAccount, 0, 0);
        }

        private void pageRegistrationLogin_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tableLayoutPanelPagePlace.Controls.Clear();
            this.pageLogin.Dock = System.Windows.Forms.DockStyle.None;
            this.pageLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelPagePlace.Controls.Add(this.pageLogin, 0, 0);
        }
        private void pageMainKnowMore_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanelPagePlace.Controls.Clear();
            this.pageAbout.Dock = System.Windows.Forms.DockStyle.None;
            this.pageAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelPagePlace.Controls.Add(this.pageAbout, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelPagePlace_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            //factoryIOProcess.Kill();
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
        }
    }
}
