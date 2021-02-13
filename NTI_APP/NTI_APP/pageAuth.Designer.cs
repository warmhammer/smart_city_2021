
namespace NTI_APP
{
    partial class pageAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageAuth));
            this.LabelEnter = new System.Windows.Forms.Label();
            this.tableLayoutPanelError = new System.Windows.Forms.TableLayoutPanel();
            this.EnteryButton = new System.Windows.Forms.Button();
            this.panelCode = new System.Windows.Forms.Panel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanelError.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelEnter
            // 
            this.tableLayoutPanelError.SetColumnSpan(this.LabelEnter, 2);
            this.LabelEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelEnter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEnter.Location = new System.Drawing.Point(3, 0);
            this.LabelEnter.Name = "LabelEnter";
            this.LabelEnter.Size = new System.Drawing.Size(418, 70);
            this.LabelEnter.TabIndex = 0;
            this.LabelEnter.Text = "ВХОД";
            this.LabelEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelEnter.Click += new System.EventHandler(this.EnteryLabel_Click);
            // 
            // tableLayoutPanelError
            // 
            this.tableLayoutPanelError.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelError.ColumnCount = 2;
            this.tableLayoutPanelError.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanelError.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanelError.Controls.Add(this.EnteryButton, 1, 2);
            this.tableLayoutPanelError.Controls.Add(this.LabelEnter, 0, 0);
            this.tableLayoutPanelError.Controls.Add(this.panelCode, 0, 1);
            this.tableLayoutPanelError.Controls.Add(this.labelError, 0, 2);
            this.tableLayoutPanelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelError.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelError.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelError.Name = "tableLayoutPanelError";
            this.tableLayoutPanelError.RowCount = 3;
            this.tableLayoutPanelError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelError.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelError.Size = new System.Drawing.Size(424, 212);
            this.tableLayoutPanelError.TabIndex = 2;
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
            this.EnteryButton.Location = new System.Drawing.Point(326, 146);
            this.EnteryButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.EnteryButton.Name = "EnteryButton";
            this.EnteryButton.Size = new System.Drawing.Size(95, 63);
            this.EnteryButton.TabIndex = 2;
            this.EnteryButton.UseVisualStyleBackColor = false;
            this.EnteryButton.Click += new System.EventHandler(this.EnteryButton_Click);
            // 
            // panelCode
            // 
            this.panelCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCode.BackgroundImage")));
            this.panelCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanelError.SetColumnSpan(this.panelCode, 2);
            this.panelCode.Controls.Add(this.textBoxCode);
            this.panelCode.Location = new System.Drawing.Point(3, 73);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(418, 64);
            this.panelCode.TabIndex = 3;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCode.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCode.Location = new System.Drawing.Point(21, 10);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.PlaceholderText = "Код из письма";
            this.textBoxCode.Size = new System.Drawing.Size(360, 45);
            this.textBoxCode.TabIndex = 2;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(3, 140);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(241, 72);
            this.labelError.TabIndex = 4;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelError);
            this.Name = "pageAuth";
            this.Size = new System.Drawing.Size(424, 212);
            this.tableLayoutPanelError.ResumeLayout(false);
            this.tableLayoutPanelError.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelEnter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelError;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button EnteryButton;

        private int code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;

        public System.EventHandler authSuccess;
    }
}
