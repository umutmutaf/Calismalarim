namespace AdoUygulama
{
    partial class sqlGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBRememberPassword = new System.Windows.Forms.CheckBox();
            this.BtOptions = new System.Windows.Forms.Button();
            this.BtHelp = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.BtConnect = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CbAuthen = new System.Windows.Forms.ComboBox();
            this.CbServerAd = new System.Windows.Forms.ComboBox();
            this.CbServerTip = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckBRememberPassword
            // 
            this.CheckBRememberPassword.AutoSize = true;
            this.CheckBRememberPassword.Location = new System.Drawing.Point(161, 206);
            this.CheckBRememberPassword.Name = "CheckBRememberPassword";
            this.CheckBRememberPassword.Size = new System.Drawing.Size(120, 17);
            this.CheckBRememberPassword.TabIndex = 32;
            this.CheckBRememberPassword.Text = "Rememer Password";
            this.CheckBRememberPassword.UseVisualStyleBackColor = true;
            // 
            // BtOptions
            // 
            this.BtOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtOptions.Location = new System.Drawing.Point(314, 249);
            this.BtOptions.Name = "BtOptions";
            this.BtOptions.Size = new System.Drawing.Size(90, 23);
            this.BtOptions.TabIndex = 31;
            this.BtOptions.Text = "Options >>";
            this.BtOptions.UseVisualStyleBackColor = true;
            // 
            // BtHelp
            // 
            this.BtHelp.Location = new System.Drawing.Point(234, 249);
            this.BtHelp.Name = "BtHelp";
            this.BtHelp.Size = new System.Drawing.Size(75, 23);
            this.BtHelp.TabIndex = 30;
            this.BtHelp.Text = "Help";
            this.BtHelp.UseVisualStyleBackColor = true;
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(154, 249);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 29;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // BtConnect
            // 
            this.BtConnect.Location = new System.Drawing.Point(74, 249);
            this.BtConnect.Name = "BtConnect";
            this.BtConnect.Size = new System.Drawing.Size(75, 23);
            this.BtConnect.TabIndex = 28;
            this.BtConnect.Text = "Connect";
            this.BtConnect.UseVisualStyleBackColor = true;
            this.BtConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(160, 177);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(242, 22);
            this.TxtPassword.TabIndex = 27;
            // 
            // CbAuthen
            // 
            this.CbAuthen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAuthen.FormattingEnabled = true;
            this.CbAuthen.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.CbAuthen.Location = new System.Drawing.Point(142, 129);
            this.CbAuthen.Name = "CbAuthen";
            this.CbAuthen.Size = new System.Drawing.Size(260, 21);
            this.CbAuthen.TabIndex = 25;
            // 
            // CbServerAd
            // 
            this.CbServerAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbServerAd.FormattingEnabled = true;
            this.CbServerAd.Location = new System.Drawing.Point(142, 104);
            this.CbServerAd.Name = "CbServerAd";
            this.CbServerAd.Size = new System.Drawing.Size(259, 21);
            this.CbServerAd.TabIndex = 24;
            // 
            // CbServerTip
            // 
            this.CbServerTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbServerTip.FormattingEnabled = true;
            this.CbServerTip.Items.AddRange(new object[] {
            "Database Engine",
            "Analysis Services",
            "Reporting Services",
            "Integration Services"});
            this.CbServerTip.Location = new System.Drawing.Point(142, 79);
            this.CbServerTip.Name = "CbServerTip";
            this.CbServerTip.Size = new System.Drawing.Size(260, 21);
            this.CbServerTip.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 24);
            this.textBox1.TabIndex = 33;
            // 
            // sqlGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdoUygulama.Properties.Resources.Ekran_Alıntısı1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(412, 283);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheckBRememberPassword);
            this.Controls.Add(this.BtOptions);
            this.Controls.Add(this.BtHelp);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtConnect);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.CbAuthen);
            this.Controls.Add(this.CbServerAd);
            this.Controls.Add(this.CbServerTip);
            this.DoubleBuffered = true;
            this.Name = "sqlGiris";
            this.Text = "sqlGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBRememberPassword;
        private System.Windows.Forms.Button BtOptions;
        private System.Windows.Forms.Button BtHelp;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BtConnect;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CbAuthen;
        private System.Windows.Forms.ComboBox CbServerAd;
        private System.Windows.Forms.ComboBox CbServerTip;
        private System.Windows.Forms.TextBox textBox1;
    }
}