namespace Generator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtMnemonic = new System.Windows.Forms.TextBox();
            this.progProcess = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lstLanguage = new System.Windows.Forms.ComboBox();
            this.progVolume = new System.Windows.Forms.ProgressBar();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblVolumeHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(12, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(313, 66);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "生成新的钱包";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMnemonic
            // 
            this.txtMnemonic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMnemonic.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMnemonic.Location = new System.Drawing.Point(13, 83);
            this.txtMnemonic.Multiline = true;
            this.txtMnemonic.Name = "txtMnemonic";
            this.txtMnemonic.Size = new System.Drawing.Size(775, 150);
            this.txtMnemonic.TabIndex = 1;
            // 
            // progProcess
            // 
            this.progProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progProcess.Location = new System.Drawing.Point(13, 420);
            this.progProcess.Name = "progProcess";
            this.progProcess.Size = new System.Drawing.Size(775, 23);
            this.progProcess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "密码（可选）：";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(555, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 36);
            this.txtPassword.TabIndex = 4;
            // 
            // lstLanguage
            // 
            this.lstLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLanguage.FormattingEnabled = true;
            this.lstLanguage.Items.AddRange(new object[] {
            "英文",
            "中文"});
            this.lstLanguage.Location = new System.Drawing.Point(667, 360);
            this.lstLanguage.Name = "lstLanguage";
            this.lstLanguage.Size = new System.Drawing.Size(121, 23);
            this.lstLanguage.TabIndex = 5;
            // 
            // progVolume
            // 
            this.progVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progVolume.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progVolume.Location = new System.Drawing.Point(345, 389);
            this.progVolume.Name = "progVolume";
            this.progVolume.Size = new System.Drawing.Size(443, 23);
            this.progVolume.TabIndex = 2;
            this.progVolume.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.Location = new System.Drawing.Point(13, 239);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(312, 77);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblVolumeHint
            // 
            this.lblVolumeHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVolumeHint.AutoSize = true;
            this.lblVolumeHint.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVolumeHint.Location = new System.Drawing.Point(13, 380);
            this.lblVolumeHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeHint.Name = "lblVolumeHint";
            this.lblVolumeHint.Size = new System.Drawing.Size(289, 32);
            this.lblVolumeHint.TabIndex = 6;
            this.lblVolumeHint.Text = "通过您的声音来提高熵：";
            this.lblVolumeHint.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.lblVolumeHint);
            this.Controls.Add(this.lstLanguage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progVolume);
            this.Controls.Add(this.progProcess);
            this.Controls.Add(this.txtMnemonic);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Name = "MainForm";
            this.Text = "素图科技——纸钱包";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtMnemonic;
        private System.Windows.Forms.ProgressBar progProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox lstLanguage;
        private System.Windows.Forms.ProgressBar progVolume;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblVolumeHint;
    }
}

