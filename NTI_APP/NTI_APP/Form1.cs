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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.userControl = new PageLogin();
            InitializeComponent();
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
            
            if (e.ClickedItem == toolStripMenuItemAccount)
            {
                this.tableLayoutPanelPagePlace.Controls.Clear();
                this.userControl.Dock = System.Windows.Forms.DockStyle.None;
                this.userControl.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.tableLayoutPanelPagePlace.Controls.Add(this.userControl, 0, 0);
            }
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
    }
}
