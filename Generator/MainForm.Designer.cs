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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBip32RootKey = new System.Windows.Forms.TextBox();
            this.progVolume = new System.Windows.Forms.ProgressBar();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(22, 23);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(273, 55);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "生成新的钱包";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMnemonic
            // 
            this.txtMnemonic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMnemonic.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMnemonic.Location = new System.Drawing.Point(22, 164);
            this.txtMnemonic.Margin = new System.Windows.Forms.Padding(6);
            this.txtMnemonic.Name = "txtMnemonic";
            this.txtMnemonic.Size = new System.Drawing.Size(1432, 36);
            this.txtMnemonic.TabIndex = 1;
            // 
            // progProcess
            // 
            this.progProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progProcess.Location = new System.Drawing.Point(22, 92);
            this.progProcess.Margin = new System.Windows.Forms.Padding(6);
            this.progProcess.Name = "progProcess";
            this.progProcess.Size = new System.Drawing.Size(1436, 49);
            this.progProcess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "密码（可选）：";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(215, 233);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 36);
            this.txtPassword.TabIndex = 4;
            // 
            // lstLanguage
            // 
            this.lstLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLanguage.FormattingEnabled = true;
            this.lstLanguage.Items.AddRange(new object[] {
            "英文",
            "中文"});
            this.lstLanguage.Location = new System.Drawing.Point(306, 30);
            this.lstLanguage.Margin = new System.Windows.Forms.Padding(6);
            this.lstLanguage.Name = "lstLanguage";
            this.lstLanguage.Size = new System.Drawing.Size(221, 40);
            this.lstLanguage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "根密码：";
            // 
            // txtBip32RootKey
            // 
            this.txtBip32RootKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBip32RootKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBip32RootKey.Location = new System.Drawing.Point(215, 294);
            this.txtBip32RootKey.Margin = new System.Windows.Forms.Padding(6);
            this.txtBip32RootKey.Name = "txtBip32RootKey";
            this.txtBip32RootKey.Size = new System.Drawing.Size(1239, 36);
            this.txtBip32RootKey.TabIndex = 4;
            // 
            // progVolume
            // 
            this.progVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progVolume.Location = new System.Drawing.Point(860, 23);
            this.progVolume.Margin = new System.Windows.Forms.Padding(6);
            this.progVolume.Name = "progVolume";
            this.progVolume.Size = new System.Drawing.Size(600, 49);
            this.progVolume.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(22, 390);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(273, 55);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.lstLanguage);
            this.Controls.Add(this.txtBip32RootKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progVolume);
            this.Controls.Add(this.progProcess);
            this.Controls.Add(this.txtMnemonic);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBip32RootKey;
        private System.Windows.Forms.ProgressBar progVolume;
        private System.Windows.Forms.Button btnPrint;
    }
}

