
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2015, 64);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1808, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 64);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripTextBox4,
            this.toolStripTextBox5,
            this.toolStripTextBox6});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(9, 9);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(832, 32);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox1.Text = "Главная";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 28);
            this.toolStripTextBox2.Text = "Личный кабинет";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox3.Text = "Склад";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox4.Size = new System.Drawing.Size(150, 28);
            this.toolStripTextBox4.Text = "Расписание";
            this.toolStripTextBox4.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox5.Size = new System.Drawing.Size(170, 28);
            this.toolStripTextBox5.Text = "Видео-поток";
            this.toolStripTextBox5.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox6.Size = new System.Drawing.Size(80, 28);
            this.toolStripTextBox6.Text = "О нас";
            this.toolStripTextBox6.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2015, 913);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Система автоматического склада";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.Button button1;
    }
}

