
namespace NTI_APP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTimetable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelPagePlace = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelPagePlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1393, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMain,
            this.toolStripMenuItemAccount,
            this.toolStripMenuItemStorage,
            this.toolStripMenuItemTimetable,
            this.toolStripMenuItemVideo,
            this.toolStripMenuItemAbout});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(9, 9);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(776, 38);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripMenuItemMain
            // 
            this.toolStripMenuItemMain.CheckOnClick = true;
            this.toolStripMenuItemMain.Name = "toolStripMenuItemMain";
            this.toolStripMenuItemMain.Size = new System.Drawing.Size(108, 34);
            this.toolStripMenuItemMain.Text = "Главная";
            // 
            // toolStripMenuItemAccount
            // 
            this.toolStripMenuItemAccount.Name = "toolStripMenuItemAccount";
            this.toolStripMenuItemAccount.Size = new System.Drawing.Size(191, 34);
            this.toolStripMenuItemAccount.Text = "Личный кабинет";
            // 
            // toolStripMenuItemStorage
            // 
            this.toolStripMenuItemStorage.Name = "toolStripMenuItemStorage";
            this.toolStripMenuItemStorage.Size = new System.Drawing.Size(87, 34);
            this.toolStripMenuItemStorage.Text = "Склад";
            // 
            // toolStripMenuItemTimetable
            // 
            this.toolStripMenuItemTimetable.Name = "toolStripMenuItemTimetable";
            this.toolStripMenuItemTimetable.Size = new System.Drawing.Size(144, 34);
            this.toolStripMenuItemTimetable.Text = "Расписание";
            // 
            // toolStripMenuItemVideo
            // 
            this.toolStripMenuItemVideo.Name = "toolStripMenuItemVideo";
            this.toolStripMenuItemVideo.Size = new System.Drawing.Size(152, 34);
            this.toolStripMenuItemVideo.Text = "Видео-поток";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(86, 34);
            this.toolStripMenuItemAbout.Text = "О нас";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1808, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 53);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.groupBox2);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Controls.Add(this.menuStrip);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2015, 53);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1069, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2009, 0);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanelPagePlace
            // 
            this.tableLayoutPanelPagePlace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelPagePlace.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelPagePlace.ColumnCount = 1;
            this.tableLayoutPanelPagePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPagePlace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPagePlace.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelPagePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPagePlace.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanelPagePlace.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelPagePlace.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanelPagePlace.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.tableLayoutPanelPagePlace.Name = "tableLayoutPanelPagePlace";
            this.tableLayoutPanelPagePlace.RowCount = 1;
            this.tableLayoutPanelPagePlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagePlace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagePlace.Size = new System.Drawing.Size(2015, 868);
            this.tableLayoutPanelPagePlace.TabIndex = 3;
            this.tableLayoutPanelPagePlace.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelPagePlace_Paint_1);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2015, 921);
            this.Controls.Add(this.tableLayoutPanelPagePlace);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Система автоматического склада";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanelPagePlace.ResumeLayout(false);
            this.tableLayoutPanelPagePlace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelHeader;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStorage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTimetable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVideo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPagePlace;
        private System.Windows.Forms.GroupBox groupBox2;

        private PageLogin pageLogin;
        private PageAbout pageAbout;
        private PageRegistration pageRegistration;

        private System.Diagnostics.Process factoryIOProcess;
    }
}

