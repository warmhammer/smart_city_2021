
namespace NTI_APP
{
    partial class LoginPage
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.labelLogin = new System.Windows.Forms.Label();
            this.panelMail = new System.Windows.Forms.Panel();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelPassForget = new System.Windows.Forms.LinkLabel();
            this.linkLabelRegistration = new System.Windows.Forms.LinkLabel();
            this.buttonEnter = new System.Windows.Forms.Button();

            this.buttonEnter.SuspendLayout();
            this.textBoxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLogin
            // 
            this.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColumnCount = 2;
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Controls.Add(this.labelLogin, 0, 0);
            this.Controls.Add(this.panelMail, 0, 1);
            this.Controls.Add(this.panelPassword, 0, 2);
            this.Controls.Add(this.linkLabelPassForget, 0, 3);
            this.Controls.Add(this.linkLabelRegistration, 0, 4);
            this.Controls.Add(this.buttonEnter, 1, 3);
            //this.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Location = new System.Drawing.Point(787, 271);
            this.MaximumSize = new System.Drawing.Size(440, 320);
            this.MinimumSize = new System.Drawing.Size(440, 320);
            this.Name = "tableLayoutPanelLogin";
            this.RowCount = 5;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Size = new System.Drawing.Size(440, 320);
            this.TabIndex = 0;
         //!this.tableLayoutPanelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pageSpace_Paint);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.SetColumnSpan(this.labelLogin, 2);
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(138, 7);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(163, 65);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "ВХОД";
         //!!!this.labelLogin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelMail
            // 
            this.panelMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMail.BackgroundImage")));
            this.panelMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SetColumnSpan(this.panelMail, 2);
            this.panelMail.Controls.Add(this.textBoxMail);
            this.panelMail.Location = new System.Drawing.Point(0, 80);
            this.panelMail.Margin = new System.Windows.Forms.Padding(0);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(440, 80);
            this.panelMail.TabIndex = 1;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Segoe UI Semilight", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMail.Location = new System.Drawing.Point(35, 17);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(368, 44);
            this.textBoxMail.TabIndex = 0;
            this.textBoxMail.Text = "Почта";
            // 
            // panelPassword
            // 
            this.panelPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPassword.BackgroundImage")));
            this.panelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SetColumnSpan(this.panelPassword, 2);
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPassword.Location = new System.Drawing.Point(0, 160);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(440, 80);
            this.panelPassword.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(35, 18);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(368, 44);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Пароль";
         //!!!!this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // linkLabelPassForget
            // 
            this.linkLabelPassForget.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelPassForget.AutoSize = true;
            this.linkLabelPassForget.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPassForget.Location = new System.Drawing.Point(10, 245);
            this.linkLabelPassForget.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.linkLabelPassForget.Name = "linkLabelPassForget";
            this.linkLabelPassForget.Size = new System.Drawing.Size(169, 30);
            this.linkLabelPassForget.TabIndex = 4;
            this.linkLabelPassForget.TabStop = true;
            this.linkLabelPassForget.Text = "Забыли пароль?";
            // 
            // linkLabelRegistration
            // 
            this.linkLabelRegistration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelRegistration.AutoSize = true;
            this.linkLabelRegistration.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRegistration.Location = new System.Drawing.Point(10, 285);
            this.linkLabelRegistration.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.linkLabelRegistration.Name = "linkLabelRegistration";
            this.linkLabelRegistration.Size = new System.Drawing.Size(134, 30);
            this.linkLabelRegistration.TabIndex = 5;
            this.linkLabelRegistration.TabStop = true;
            this.linkLabelRegistration.Text = "Регистрация";
            this.linkLabelRegistration.Click += new System.EventHandler(this.linkLabelRegistration_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.ForeColor = System.Drawing.Color.White;



            //this.buttonEnter.Image = new Bitmap(Properties.Resources.buttonEnter);

            
            this.buttonEnter.Image = ((System.Drawing.Image)(resources.GetObject("textBox"))); //(".\Resources\);"buttonEnter.Image"
            

            this.buttonEnter.Location = new System.Drawing.Point(325, 240);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.buttonEnter.Name = "buttonEnter";
            this.SetRowSpan(this.buttonEnter, 2);
            this.buttonEnter.Size = new System.Drawing.Size(104, 80);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.UseMnemonic = false;
            this.buttonEnter.UseVisualStyleBackColor = false;
            
        }

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelMail;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.LinkLabel linkLabelPassForget;
        private System.Windows.Forms.LinkLabel linkLabelRegistration;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEnter;
    }
}
