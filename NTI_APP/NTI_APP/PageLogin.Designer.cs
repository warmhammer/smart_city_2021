
using System.Drawing;


namespace NTI_APP
{
    partial class PageLogin
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageLogin));
            this.EnteryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EnteryBatton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.linkWastePassword = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnteryLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.EnteryLabel, 2);
            this.EnteryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnteryLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnteryLabel.Location = new System.Drawing.Point(3, 0);
            this.EnteryLabel.Name = "EnteryLabel";
            this.EnteryLabel.Size = new System.Drawing.Size(418, 50);
            this.EnteryLabel.TabIndex = 0;
            this.EnteryLabel.Text = "ВХОД";
            this.EnteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EnteryBatton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EnteryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkRegistration, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkWastePassword, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(799, 236);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 263);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EnteryBatton
            // 
            this.EnteryBatton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnteryBatton.BackColor = System.Drawing.Color.White;
            this.EnteryBatton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EnteryBatton.BackgroundImage")));
            this.EnteryBatton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnteryBatton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnteryBatton.FlatAppearance.BorderSize = 0;
            this.EnteryBatton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.EnteryBatton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnteryBatton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnteryBatton.Location = new System.Drawing.Point(326, 195);
            this.EnteryBatton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.EnteryBatton.Name = "EnteryBatton";
            this.tableLayoutPanel1.SetRowSpan(this.EnteryBatton, 2);
            this.EnteryBatton.Size = new System.Drawing.Size(95, 46);
            this.EnteryBatton.TabIndex = 2;
            this.EnteryBatton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 64);
            this.panel2.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(23, 22);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Пароль";
            this.textBoxPassword.Size = new System.Drawing.Size(233, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 63);
            this.panel1.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(23, 19);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Почта";
            this.textBoxEmail.Size = new System.Drawing.Size(248, 26);
            this.textBoxEmail.TabIndex = 2;
            // 
            // linkRegistration
            // 
            this.linkRegistration.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkRegistration.LinkColor = System.Drawing.Color.Black;
            this.linkRegistration.Location = new System.Drawing.Point(3, 236);
            this.linkRegistration.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(206, 15);
            this.linkRegistration.TabIndex = 5;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "РЕГИСТРАЦИЯ";
            this.linkRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkRegistration.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkWastePassword
            // 
            this.linkWastePassword.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkWastePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkWastePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.linkWastePassword.LinkColor = System.Drawing.Color.Black;
            this.linkWastePassword.Location = new System.Drawing.Point(3, 209);
            this.linkWastePassword.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.linkWastePassword.Name = "linkWastePassword";
            this.linkWastePassword.Size = new System.Drawing.Size(206, 15);
            this.linkWastePassword.TabIndex = 4;
            this.linkWastePassword.TabStop = true;
            this.linkWastePassword.Text = "ЗАБЫЛИ ПАРОЛЬ?";
            this.linkWastePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkWastePassword.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkWastePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWastePassword_LinkClicked);
            // 
            // PageLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PageLogin";
            this.Size = new System.Drawing.Size(1924, 868);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EnteryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EnteryBatton;
        private System.Windows.Forms.LinkLabel linkWastePassword;
        private System.Windows.Forms.LinkLabel linkRegistration;
    }
}
