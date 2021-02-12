
using System.Drawing;
using MySql.Data.MySqlClient;


namespace NTI_APP
{
    partial class PageRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageRegistration));
            this.EnteryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EnteryButton = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelMail = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnteryLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.EnteryLabel, 2);
            this.EnteryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnteryLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnteryLabel.Location = new System.Drawing.Point(3, 0);
            this.EnteryLabel.Name = "EnteryLabel";
            this.EnteryLabel.Size = new System.Drawing.Size(418, 70);
            this.EnteryLabel.TabIndex = 0;
            this.EnteryLabel.Text = "РЕГИСТРАЦИЯ";
            this.EnteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.EnteryButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EnteryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkForgotPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelError, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EnteryButton
            // 
            this.EnteryButton.BackColor = System.Drawing.Color.White;
            this.EnteryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EnteryButton.BackgroundImage")));
            this.EnteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnteryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnteryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EnteryButton.FlatAppearance.BorderSize = 0;
            this.EnteryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.EnteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnteryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnteryButton.Location = new System.Drawing.Point(326, 216);
            this.EnteryButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.EnteryButton.Name = "EnteryButton";
            this.tableLayoutPanel1.SetRowSpan(this.EnteryButton, 2);
            this.EnteryButton.Size = new System.Drawing.Size(95, 71);
            this.EnteryButton.TabIndex = 2;
            this.EnteryButton.UseVisualStyleBackColor = false;
            this.EnteryButton.Click += new System.EventHandler(this.EnteryButton_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPassword.BackgroundImage")));
            this.panelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.panelPassword, 2);
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Location = new System.Drawing.Point(3, 143);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(418, 64);
            this.panelPassword.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(23, 10);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "Пароль";

            this.textBoxPassword.Size = new System.Drawing.Size(360, 32);


            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // panelMail
            // 
            this.panelMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMail.BackgroundImage")));
            this.panelMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.panelMail, 2);
            this.panelMail.Controls.Add(this.textBoxEmail);
            this.panelMail.Location = new System.Drawing.Point(3, 73);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(418, 63);
            this.panelMail.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(23, 10);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Почта";

            this.textBoxEmail.Size = new System.Drawing.Size(360, 32);


            this.textBoxEmail.TabIndex = 2;
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.linkForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkForgotPassword.LinkColor = System.Drawing.Color.Black;
            this.linkForgotPassword.Location = new System.Drawing.Point(3, 210);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(this.linkForgotPassword, 2);
            this.linkForgotPassword.Size = new System.Drawing.Size(241, 80);
            this.linkForgotPassword.TabIndex = 4;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "ВЕРНУТЬСЯ КО ВХОДУ";
            this.linkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkForgotPassword.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWastePassword_LinkClicked);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelError, 2);
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(3, 290);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(418, 80);
            this.labelError.TabIndex = 5;
            // 
            // PageRegistration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PageRegistration";
            this.Size = new System.Drawing.Size(424, 370);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelMail.ResumeLayout(false);
            this.panelMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EnteryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelMail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button EnteryButton;
        private System.Windows.Forms.LinkLabel linkForgotPassword;

        public System.Windows.Forms.LinkLabelLinkClickedEventHandler LoginLinkClicked;
        private System.Windows.Forms.Label labelError;
        private MySqlConnection conn;
    }
}
