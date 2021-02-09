
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
            this.toolStripTextBoxMain = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxAccount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxStorage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxTimetable = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxVideo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxAbout = new System.Windows.Forms.ToolStripTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.toolStripTextBoxMain,
            this.toolStripTextBoxAccount,
            this.toolStripTextBoxStorage,
            this.toolStripTextBoxTimetable,
            this.toolStripTextBoxVideo,
            this.toolStripTextBoxAbout});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(9, 9);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(832, 32);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripTextBoxMain
            // 
            this.toolStripTextBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxMain.Name = "toolStripTextBoxMain";
            this.toolStripTextBoxMain.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxMain.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBoxMain.Text = "Главная";
            this.toolStripTextBoxMain.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBoxAccount
            // 
            this.toolStripTextBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxAccount.Name = "toolStripTextBoxAccount";
            this.toolStripTextBoxAccount.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBoxAccount.Size = new System.Drawing.Size(200, 28);
            this.toolStripTextBoxAccount.Text = "Личный кабинет";
            this.toolStripTextBoxAccount.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBoxStorage
            // 
            this.toolStripTextBoxStorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxStorage.Name = "toolStripTextBoxStorage";
            this.toolStripTextBoxStorage.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxStorage.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBoxStorage.Text = "Склад";
            this.toolStripTextBoxStorage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBoxTimetable
            // 
            this.toolStripTextBoxTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxTimetable.Name = "toolStripTextBoxTimetable";
            this.toolStripTextBoxTimetable.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxTimetable.Size = new System.Drawing.Size(150, 28);
            this.toolStripTextBoxTimetable.Text = "Расписание";
            this.toolStripTextBoxTimetable.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBoxVideo
            // 
            this.toolStripTextBoxVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxVideo.Name = "toolStripTextBoxVideo";
            this.toolStripTextBoxVideo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxVideo.Size = new System.Drawing.Size(170, 28);
            this.toolStripTextBoxVideo.Text = "Видео-поток";
            this.toolStripTextBoxVideo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBoxAbout
            // 
            this.toolStripTextBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxAbout.Name = "toolStripTextBoxAbout";
            this.toolStripTextBoxAbout.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBoxAbout.Size = new System.Drawing.Size(80, 28);
            this.toolStripTextBoxAbout.Text = "О нас";
            this.toolStripTextBoxAbout.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Controls.Add(this.menuStrip);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(2015, 53);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2015, 862);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(761, 343);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 175);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2015, 921);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Система автоматического склада";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMain;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAccount;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxStorage;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTimetable;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxVideo;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAbout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

